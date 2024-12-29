using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OrderStockManagement.Models;

namespace OrderStockManagement
{
    public partial class Form1 : Form
    {
        private readonly object lockObject = new object();
        private readonly List<Order> orderQueue = new List<Order>();
        private Thread orderProcessingThread;

        public Form1()
        {
            InitializeComponent();
            CustomizeUI();
            StartOrderProcessing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeRandomCustomers();
            LoadCustomers();
            LoadProducts();
            LoadLogs();
            UpdateOrderQueueDisplay();

			customersGridView.MultiSelect = true;
			customersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
			checkColumn.HeaderText = "Seç";
			checkColumn.Name = "checkBoxColumn";
			checkColumn.Width = 30;
			checkColumn.ReadOnly = false;
			customersGridView.Columns.Insert(0, checkColumn);

			productsGridView.MultiSelect = true;
			productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DataGridViewCheckBoxColumn checkColumn2 = new DataGridViewCheckBoxColumn();
			checkColumn2.HeaderText = "Seç";
			checkColumn2.Name = "checkBoxColumn";
			checkColumn2.Width = 30;
			checkColumn2.ReadOnly = false;
			productsGridView.Columns.Insert(0, checkColumn2);
		}

        private void CustomizeUI()
        {
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);

            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.SteelBlue;
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }

                if (control is DataGridView gridView)
                {
                    gridView.BackgroundColor = Color.White;
                    gridView.BorderStyle = BorderStyle.Fixed3D;
                    gridView.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
                    gridView.DefaultCellStyle.SelectionForeColor = Color.White;
                    gridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                }
            }

            titleLabel.ForeColor = Color.DarkSlateBlue;
            titleLabel.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        }

        private void InitializeRandomCustomers()
        {
            Random random = new Random();
            int customerCount = random.Next(5, 11);
            int premiumCount = 0;

            for (int i = 0; i < customerCount; i++)
            {
                string customerName = $"Customer{i + 1}";
                float budget = random.Next(500, 3001);
                string customerType = premiumCount < 2 ? "Premium" : (random.Next(2) == 0 ? "Premium" : "Standard");
                if (customerType == "Premium") premiumCount++;

                string query = "INSERT INTO Customers (CustomerName, Budget, CustomerType, TotalSpent) VALUES (@name, @budget, @type, 0)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@name", customerName),
                    new MySqlParameter("@budget", budget),
                    new MySqlParameter("@type", customerType)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başlık tıklandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadCustomers()
        {
            string query = "SELECT * FROM Customers ORDER BY CustomerType DESC, CustomerID ASC";
            customersGridView.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

		public void LoadProducts()
		{
			string query = "SELECT * FROM Products";
			DataTable productsTable = DatabaseHelper.ExecuteQuery(query);

			if (productsGridView.InvokeRequired)
			{
				productsGridView.Invoke(new Action(() =>
				{
					productsGridView.DataSource = productsTable;
				}));
			}
			else
			{
				productsGridView.DataSource = productsTable;
			}

			HighlightLowStockProducts();
		}


		public void LoadLogs()
		{
			try
			{
				string query = "SELECT * FROM Logs ORDER BY LogDate DESC";
				DataTable logsTable = DatabaseHelper.ExecuteQuery(query);

				if (logsGridView.InvokeRequired)
				{
					logsGridView.Invoke(new Action(() =>
					{
						logsGridView.DataSource = logsTable;
					}));
				}
				else
				{
					logsGridView.DataSource = logsTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Log yükleme sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void HighlightLowStockProducts()
        {
            foreach (DataGridViewRow row in productsGridView.Rows)
            {
                if (row.Cells["Stock"].Value != null && int.TryParse(row.Cells["Stock"].Value.ToString(), out int stock))
                {
                    if (stock < 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }




		private void UpdateOrderQueueDisplay()
		{
			lock (orderQueue)
			{
				var dataSource = orderQueue
					.Select(o => new { o.CustomerId, o.ProductId, o.Quantity, o.Priority })
					.OrderByDescending(o => o.Priority)
					.ToList();

				if (orderQueueGridView.InvokeRequired)
				{
					orderQueueGridView.Invoke(new Action(() =>
					{
						orderQueueGridView.DataSource = dataSource;
					}));
				}
				else
				{
					orderQueueGridView.DataSource = dataSource;
				}
			}
		}


		private void ProcessOrders()
        {
            while (true)
            {
                Order order = null;

                lock (orderQueue)
                {
                    if (orderQueue.Count > 0)
                    {
                        orderQueue.Sort((a, b) => b.Priority.CompareTo(a.Priority));
                        order = orderQueue[0];
                        orderQueue.RemoveAt(0);
                    }
                }

                if (order != null)
                {
                    ProcessOrder(order);
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void ProcessOrder(Order order)
        {
            lock (lockObject)
            {
                try
                {
                    string productQuery = "SELECT Stock, Price FROM Products WHERE ProductID = @productId";
                    MySqlParameter[] productParameters = { new MySqlParameter("@productId", order.ProductId) };
                    DataTable productData = DatabaseHelper.ExecuteQuery(productQuery, productParameters);

                    if (productData.Rows.Count == 0)
                    {
                        LogAction(order.CustomerId, "Error", "Ürün bulunamadı.");
                        return;
                    }

                    int stock = Convert.ToInt32(productData.Rows[0]["Stock"]);
                    float price = Convert.ToSingle(productData.Rows[0]["Price"]);
                    float totalPrice = price * order.Quantity;

                    string customerQuery = "SELECT Budget, CustomerType FROM Customers WHERE CustomerID = @customerId";
                    MySqlParameter[] customerParameters = { new MySqlParameter("@customerId", order.CustomerId) };
                    DataTable customerData = DatabaseHelper.ExecuteQuery(customerQuery, customerParameters);

                    if (customerData.Rows.Count == 0)
                    {
                        LogAction(order.CustomerId, "Error", "Müşteri bulunamadı.");
                        return;
                    }

                    float budget = Convert.ToSingle(customerData.Rows[0]["Budget"]);

                    if (order.Quantity > stock)
                    {
                        LogAction(order.CustomerId, "Error", "Yetersiz stok.");
                        return;
                    }

                    if (totalPrice > budget)
                    {
                        LogAction(order.CustomerId, "Error", "Yetersiz bütçe.");
                        return;
                    }

                    string updateStockQuery = "UPDATE Products SET Stock = Stock - @quantity WHERE ProductID = @productId";
                    MySqlParameter[] updateStockParams = {
                        new MySqlParameter("@quantity", order.Quantity),
                        new MySqlParameter("@productId", order.ProductId)
                    };
                    DatabaseHelper.ExecuteNonQuery(updateStockQuery, updateStockParams);

                    string updateBudgetQuery = "UPDATE Customers SET Budget = Budget - @totalPrice WHERE CustomerID = @customerId";
                    MySqlParameter[] budgetParams = {
                        new MySqlParameter("@totalPrice", totalPrice),
                        new MySqlParameter("@customerId", order.CustomerId)
                    };
                    DatabaseHelper.ExecuteNonQuery(updateBudgetQuery, budgetParams);

                    LogAction(order.CustomerId, "Info", $"Sipariş tamamlandı: Ürün ID={order.ProductId}, Miktar={order.Quantity}");
                }
                catch (Exception ex)
                {
                    LogAction(order.CustomerId, "Error", $"Sipariş işleme sırasında hata: {ex.Message}");
                }
                finally
                {
                    LoadProducts();
                    LoadLogs();
                    UpdateOrderQueueDisplay();
                }
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Frm_Urun_ekle frm = new Frm_Urun_ekle();
            frm.Show();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Frm_M_ekle frm = new Frm_M_ekle();
            frm.Show();
        }

		public void LogAction(int? customerId, string logType, string details, int? productId = null)
		{
			string query = "INSERT INTO Logs (CustomerID, LogType, LogDetails, LogDate, ProductID) VALUES (@customerId, @logType, @details, @logDate, @productId)";
			MySqlParameter[] parameters = {
		new MySqlParameter("@customerId", customerId.HasValue ? (object)customerId.Value : DBNull.Value),
		new MySqlParameter("@logType", logType),
		new MySqlParameter("@details", details),
		new MySqlParameter("@logDate", DateTime.Now),
		new MySqlParameter("@productId", productId.HasValue ? (object)productId.Value : DBNull.Value)
	};

			DatabaseHelper.ExecuteNonQuery(query, parameters);
		}


		private void StartOrderProcessing()
        {
            orderProcessingThread = new Thread(ProcessOrders) { IsBackground = true };
            orderProcessingThread.Start();
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void customerBudgetTextBox_TextChanged(object sender, EventArgs e) { }
        private void customerNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void productStockTextBox_TextChanged(object sender, EventArgs e) { }
        private void productPriceTextBox_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void customerNameLabel_Click(object sender, EventArgs e) { }
        private void logLabel_Click(object sender, EventArgs e) { }

		private void customerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void customersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Frm_Giris frmGiris = new Frm_Giris(); 
			frmGiris.Show();
            this.Hide();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void orderCustomerIdLabel_Click(object sender, EventArgs e)
		{

		}


		private void deleteProductButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Checkbox'ı işaretli olan ürünlerin ID'lerini topla
				List<int> productIdsToDelete = new List<int>();

				foreach (DataGridViewRow row in productsGridView.Rows)
				{
					// Eğer checkbox işaretliyse
					bool isChecked = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
					if (isChecked)
					{
						int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
						productIdsToDelete.Add(productId);
					}
				}

				if (productIdsToDelete.Count == 0)
				{
					MessageBox.Show("Lütfen silmek istediğiniz ürünleri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				foreach (int productId in productIdsToDelete)
				{
					// Ürünü veritabanından sil
					string query = "DELETE FROM Products WHERE ProductID = @productId";
					MySqlParameter[] parameters = {
				new MySqlParameter("@productId", productId)
			};
					DatabaseHelper.ExecuteNonQuery(query, parameters);

					// Log tablosuna ürün silindi bilgisini yaz
					LogAction(null, "Info", $"Ürün silindi. ProductID: {productId}", productId);
				}

				// Arayüzü güncelle
				LoadProducts();
				LoadLogs();

				string deletedProducts = string.Join(", ", productIdsToDelete);
				MessageBox.Show($"Ürünler başarıyla silindi! Silinen ürünler: {deletedProducts}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ürün silme sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
