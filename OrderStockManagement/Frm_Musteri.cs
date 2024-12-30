using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OrderStockManagement.Models;

namespace OrderStockManagement
{
	public partial class Frm_Musteri : Form
	{

		private readonly Form1 frm1;
		private readonly List<Order> orderQueue = new List<Order>();
		public int CustomerId { get; set; } 
		public Frm_Musteri(Form1 form1, List<Order> sharedOrderQueue)
		{
			InitializeComponent();
			frm1 = form1;
			orderQueue = sharedOrderQueue;
		}

		public string M_id;
		private void Frm_Musteri_Load(object sender, EventArgs e)
		{
			LblNo.Text = M_id;

			string query = "SELECT CustomerName, Budget FROM customers WHERE CustomerID=@p1";

			try
			{
				// Parametreyi ekle
				MySqlParameter[] parameters = {
			new MySqlParameter("@p1", LblNo.Text) // LblNo.Text, CustomerID olarak kullanılıyor
        };

				// Sorguyu çalıştır ve sonucu oku
				DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

				if (result.Rows.Count > 0)
				{
					// CustomerName sütununu LblAd.Text'e yaz
					LblAd.Text = result.Rows[0]["CustomerName"].ToString();
					LbButce.Text = result.Rows[0]["Budget"].ToString();
				}
				else
				{
					// Müşteri bulunamazsa uyarı ver
					MessageBox.Show("Müşteri bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				// Hata yönetimi
				MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			LoadProducts();
			
		}


        private void LoadProducts()
        {
            string query = "SELECT ProductID, ProductName, Price FROM Products";
            DataTable productsTable = DatabaseHelper.ExecuteQuery(query);

            if (m_productsGridView.InvokeRequired)
            {
                m_productsGridView.Invoke(new Action(() =>
                {
                    m_productsGridView.DataSource = productsTable;
                }));
            }
            else
            {
                m_productsGridView.DataSource = productsTable;
            }

        }

		


		private void placeOrderButton_Click_1(object sender, EventArgs e)
        {
			
			try
            {
                int customerId = int.Parse(LblNo.Text);
                int productId = int.Parse(orderProductIdTextBox.Text);
                int quantity = int.Parse(orderQuantityTextBox.Text);

                if (quantity > 5)
                {
                    string errorMessage = "Müşteri 5'ten fazla ürün sipariş edemez.";
					frm1.LogAction(customerId, "Error", errorMessage);
                    MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ürün stok kontrolü
     //           int currentStock = GetProductStockById(productId);
     //           if (currentStock < quantity)
     //           {
     //               string errorMessage = "Ürün stoğu yetersiz.";
					//frm1.LogAction(customerId, "Error", errorMessage);
     //               MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
     //               return;
     //           }

                // Müşteri bakiye kontrolü (Budget)
                decimal productPrice = GetProductPriceById(productId);
                decimal totalCost = productPrice * quantity;
                decimal customerBudget = GetCustomerBalance(customerId);

                if (customerBudget < totalCost)
                {
                    string errorMessage = "Müşteri bakiyesi (budget) yetersiz.";
					frm1.LogAction(customerId, "Error", $"{errorMessage} | Gerekli Bakiye: {totalCost:C}, Mevcut Bakiye: {customerBudget:C}");
                    MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

				// Sipariş listesine ekle
				lock (orderQueue)
				{
					orderQueue.Add(new Order(customerId, productId, quantity));
					frm1.AddOrderToDatabase(new Order(customerId, productId, quantity));
				}

				// Log kaydı oluştur
				frm1.LogAction(customerId, "Info", $"Sipariş sıraya alındı: Ürün ID: {productId}, Miktar: {quantity}", productId);
				frm1.UpdateOrderQueueDisplay();
				UpdateOrderQueueDisplay();

				// Kullanıcıya bilgi mesajı göster
				MessageBox.Show("Sipariş sıraya alındı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli ürün ID ve miktar bilgisi girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Sipariş ekleme sırasında bir hata oluştu: {ex.Message}";
                frm1.LogAction(null, "Error", errorMessage);
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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



        private decimal GetCustomerBalance(int customerId)
        {
            string query = "SELECT Budget FROM customers WHERE CustomerID = @customerId";
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@customerId", customerId);
                connection.Open();
                var result = command.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0m;
            }
        }


		//private int GetProductStockById(int productId)
		//{
		//    string query = "SELECT Stock FROM products WHERE ProductID = @productId";
		//    using (MySqlConnection connection = DatabaseHelper.GetConnection())
		//    using (MySqlCommand command = new MySqlCommand(query, connection))
		//    {
		//        command.Parameters.AddWithValue("@productId", productId);
		//        connection.Open();
		//        var result = command.ExecuteScalar();
		//        return result != null ? Convert.ToInt32(result) : 0;
		//    }
		//}


		private string GetProductNameById(int productId)
		{
			string query = "SELECT ProductName FROM products WHERE ProductID = @productId";
			using (MySqlConnection connection = DatabaseHelper.GetConnection())
			using (MySqlCommand command = new MySqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@productId", productId);
				connection.Open();
				var result = command.ExecuteScalar();
				return result != null ? result.ToString() : "Bilinmiyor";
			}
		}




		private void UpdateOrderQueueDisplay()
		{
			lock (orderQueue)
			{
				DataTable dataTable = siparisdataGridView.DataSource as DataTable ?? new DataTable();

				// Eğer tablo ilk kez oluşturuluyorsa kolonları tanımla
				if (dataTable.Columns.Count == 0)
				{
					dataTable.Columns.Add("ProductId", typeof(int));
					dataTable.Columns.Add("ProductName", typeof(string));
					dataTable.Columns.Add("Quantity", typeof(int));
					dataTable.Columns.Add("ProductPrice", typeof(decimal));
					dataTable.Columns.Add("TotalCost", typeof(decimal));
				}

				// Sıradaki her siparişi tabloya ekle ve log oluştur
				foreach (var order in orderQueue)
				{
					// Eğer sipariş zaten tabloda varsa ekleme
					if (dataTable.Rows.Cast<DataRow>().Any(row => (int)row["ProductId"] == order.ProductId))
						continue;

					// Yeni siparişi tabloya ekle
					dataTable.Rows.Add(
						order.ProductId,
						GetProductNameById(order.ProductId),
						order.Quantity,
						GetProductPriceById(order.ProductId),
						order.Quantity * GetProductPriceById(order.ProductId)
					);

					// Log kaydı oluştur
					frm1.LogAction(
						order.CustomerId,
						"Info",
						$"Log: Sipariş listesine eklendi - Ürün ID: {order.ProductId}, Miktar: {order.Quantity}",
						order.ProductId
					);
				}

				// DataGridView'i güncelle
				if (siparisdataGridView.InvokeRequired)
				{
					siparisdataGridView.Invoke(new Action(() =>
					{
						siparisdataGridView.DataSource = dataTable;
					}));
				}
				else
				{
					siparisdataGridView.DataSource = dataTable;
				}
			}
		}





		private void Frm_Musteri_FormClosing(object sender, FormClosingEventArgs e)
		{
			Frm_Giris fr =new Frm_Giris();
			fr.Show();
			this.Hide();	
		}

		
	}
}
