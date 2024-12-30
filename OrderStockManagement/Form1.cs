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
        public readonly List<Order> orderQueue = new List<Order>();
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
            // Sipariş listesi yükleme ve animasyon
            UpdateOrderQueueDisplay();
            AnimateOrderQueue();

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
			checkColumn2.Name = "checkBoxColumn2";
			checkColumn2.Width = 30;
			checkColumn2.ReadOnly = false;
			productsGridView.Columns.Insert(0, checkColumn2);

			//productsGridView.ReadOnly=true;
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




		public void UpdateOrderQueueDisplay()
		{
			try
			{
				string query = "SELECT OrderID, CustomerID, ProductID, Quantity, TotalPrice, OrderDate, OrderStatus FROM Orders";
				DataTable ordersTable = DatabaseHelper.ExecuteQuery(query);

				if (orderQueueGridView.InvokeRequired)
				{
					// UI iş parçacığında güncelleme
					orderQueueGridView.Invoke(new Action(() =>
					{
						orderQueueGridView.DataSource = ordersTable;
					}));
				}
				else
				{
					orderQueueGridView.DataSource = ordersTable;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Sipariş listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		public void AddOrderToDatabase(Order order)
		{
			string query = "INSERT INTO Orders (CustomerID, ProductID, Quantity, TotalPrice, OrderDate, OrderStatus) " +
						   "VALUES (@customerId, @productId, @quantity, @totalPrice, @orderDate, @orderStatus)";
			MySqlParameter[] parameters = {
		new MySqlParameter("@customerId", order.CustomerId),
		new MySqlParameter("@productId", order.ProductId),
		new MySqlParameter("@quantity", order.Quantity),
		new MySqlParameter("@totalPrice", order.Quantity * GetProductPriceById(order.ProductId)),
		new MySqlParameter("@orderDate", DateTime.Now),
		new MySqlParameter("@orderStatus", "Pending")
	};

			DatabaseHelper.ExecuteNonQuery(query, parameters);
		}


		private decimal GetProductPriceById(int productId)
		{
			string query = "SELECT Price FROM products WHERE ProductID = @productId";
			using (MySqlConnection connection = DatabaseHelper.GetConnection())
			using (MySqlCommand command = new MySqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@productId", productId);
				connection.Open();
				var result = command.ExecuteScalar();
				return result != null ? Convert.ToDecimal(result) : 0m;
			}
		}







		private string GetCustomerNameById(int customerId)
        {
            string query = "SELECT CustomerName FROM customers WHERE CustomerID = @customerId";
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@customerId", customerId);
                connection.Open();
                var result = command.ExecuteScalar();
                return result?.ToString() ?? "Bilinmeyen Müşteri";
            }
        }

        private string GetProductNameById(int productId)
        {
            string query = "SELECT ProductName FROM products WHERE ProductID = @productId";
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@productId", productId);
                connection.Open();
                var result = command.ExecuteScalar();
                return result?.ToString() ?? "Bilinmeyen Ürün";
            }
        }




        private void AnimateOrderQueue()
        {
            // Örnek olarak bir animasyon efekti (listeyi yeniden yüklerken)
            orderQueueGridView.ClearSelection();
            for (int i = 0; i < orderQueueGridView.Rows.Count; i++)
            {
                orderQueueGridView.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightBlue : Color.LightGray;
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
                        orderQueue.Sort((a, b) => b.Priority.CompareTo(a.Priority)); // Öncelik sıralaması
                        order = orderQueue[0];
                        orderQueue.RemoveAt(0); // İlk siparişi kaldır
                    }
                }

                if (order != null)
                {
                    ProcessOrder(order); // Siparişi işleme
                }
                else
                {
                    Thread.Sleep(1000); // Eğer sipariş yoksa bir süre bekle
                }

                // Sipariş listesi güncelleme ve animasyon
                UpdateOrderQueueDisplay();
                AnimateOrderQueue();
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

        
        
        private void logLabel_Click(object sender, EventArgs e) { }


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

		private void editProductButton_Click(object sender, EventArgs e)
		{
			int selectedCount = 0;
			int productId = 0;

			foreach (DataGridViewRow row in productsGridView.Rows)
			{
				DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumn2"];
				if (checkBox.Value != null && (bool)checkBox.Value == true)
				{
					selectedCount++;
					productId = Convert.ToInt32(row.Cells["ProductID"].Value);
				}
			}

			if (selectedCount == 1)
			{
				int productID = Convert.ToInt32(productsGridView.SelectedRows[0].Cells["ProductID"].Value);
				string productName = productsGridView.SelectedRows[0].Cells["ProductName"].Value.ToString();
				int stock = Convert.ToInt32(productsGridView.SelectedRows[0].Cells["Stock"].Value);
				decimal price = Convert.ToDecimal(productsGridView.SelectedRows[0].Cells["Price"].Value);

				// Frm_urun_guncelle formunu başlat ve bilgileri aktar
				frm_urun_gun frm = new frm_urun_gun(productID, productName, stock, price);
				frm.Show();

			}
			else
			{
				MessageBox.Show("Lütfen yalnızca bir malzeme seçin.");
			}
		}

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            int selectedCount = 0;
            int customerId = 0;
            string customerName = "";
            float budget = 0;
            string customerType = "";

            foreach (DataGridViewRow row in customersGridView.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumn"];
                if (checkBox.Value != null && (bool)checkBox.Value == true)
                {
                    selectedCount++;
                    customerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
                    customerName = row.Cells["CustomerName"].Value.ToString();
                    budget = Convert.ToSingle(row.Cells["Budget"].Value);
                    customerType = row.Cells["CustomerType"].Value.ToString();
                }
            }

            if (selectedCount == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (selectedCount > 1)
            {
                MessageBox.Show("Sadece bir müşteri seçebilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frm_musteri_gun customerUpdateForm = new frm_musteri_gun(customerId, customerName, budget, customerType);
                customerUpdateForm.ShowDialog();
                LoadCustomers(); // Müşteri listesini güncelle
            }
        }

		private void BtnOnay_Click(object sender, EventArgs e)
		{
			try
			{
				string getOrdersQuery = "SELECT * FROM Orders WHERE OrderStatus = 'Beklemede'";
				DataTable pendingOrders = DatabaseHelper.ExecuteQuery(getOrdersQuery);

				foreach (DataRow order in pendingOrders.Rows)
				{
					int customerId = Convert.ToInt32(order["CustomerID"]);
					int productId = Convert.ToInt32(order["ProductID"]);
					int quantity = Convert.ToInt32(order["Quantity"]);
					decimal totalPrice = Convert.ToDecimal(order["TotalPrice"]);

					// Stock update
					string updateStockQuery = "UPDATE Products SET Stock = Stock - @quantity WHERE ProductID = @productId";
					MySqlParameter[] updateStockParams = {
				new MySqlParameter("@quantity", quantity),
				new MySqlParameter("@productId", productId)
			};
					DatabaseHelper.ExecuteNonQuery(updateStockQuery, updateStockParams);

					// Budget update
					string updateBudgetQuery = "UPDATE Customers SET Budget = Budget - @totalPrice WHERE CustomerID = @customerId";
					MySqlParameter[] updateBudgetParams = {
				new MySqlParameter("@totalPrice", totalPrice),
				new MySqlParameter("@customerId", customerId)
			};
					DatabaseHelper.ExecuteNonQuery(updateBudgetQuery, updateBudgetParams);

					// Order status update
					string updateOrderQuery = "UPDATE Orders SET OrderStatus = 'Onaylandı' WHERE OrderID = @orderId";
					MySqlParameter[] updateOrderParams = {
				new MySqlParameter("@orderId", order["OrderID"])
			};
					DatabaseHelper.ExecuteNonQuery(updateOrderQuery, updateOrderParams);

					LogAction(customerId, "Info", $"Sipariş onaylandı: Ürün ID={productId}, Miktar={quantity}");

					// Clear order from queue
					lock (orderQueue)
					{
						orderQueue.RemoveAll(o => o.CustomerId == customerId && o.ProductId == productId);
					}
				}

				// Refresh all tables
				LoadCustomers();
				LoadProducts();
				LoadLogs();
				UpdateOrderQueueDisplay();

				MessageBox.Show("Siparişler onaylandı ve işlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Sipariş onaylama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
