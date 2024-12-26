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

		private readonly List<Order> orderQueue = new List<Order>();
		public Frm_Musteri()
		{
			InitializeComponent();
		}

		public string M_id;
		private void Frm_Musteri_Load(object sender, EventArgs e)
		{
			LblNo.Text = M_id;

			string query = "SELECT CustomerName FROM customers WHERE CustomerID=@p1";

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
			string query = "SELECT * FROM Products";
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

			HighlightLowStockProducts();
		}

		private void HighlightLowStockProducts()
		{
			foreach (DataGridViewRow row in m_productsGridView.Rows)
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

		private void LogAction(int? customerId, string logType, string details)
		{
			string query = "INSERT INTO Logs (CustomerID, LogType, LogDetails, LogDate) VALUES (@customerId, @logType, @details, @logDate)";
			MySqlParameter[] parameters = {
				new MySqlParameter("@customerId", customerId.HasValue ? (object)customerId.Value : DBNull.Value),
				new MySqlParameter("@logType", logType),
				new MySqlParameter("@details", details),
				new MySqlParameter("@logDate", DateTime.Now)
			};

			DatabaseHelper.ExecuteNonQuery(query, parameters);
		}

		private void placeOrderButton_Click_1(object sender, EventArgs e)
		{
			try
			{
				// Girişlerden alınan müşteri ve ürün bilgilerini al
				int customerId = int.Parse(LblNo.Text);
				int productId = int.Parse(orderProductIdTextBox.Text);
				int quantity = int.Parse(orderQuantityTextBox.Text);

				// Sipariş listesine ekle
				lock (orderQueue)
				{
					orderQueue.Add(new Order(customerId, productId, quantity));
				}

				// İşlem log kaydı oluştur
				LogAction(customerId, "Info", "Sipariş sıraya alındı.");

				// Sipariş listesini güncelle
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
				MessageBox.Show($"Sipariş ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateOrderQueueDisplay()
		{
			lock (orderQueue)
			{
				var dataSource = orderQueue
					.Select(o => new { o.ProductId, ProductName = GetProductNameById(o.ProductId), o.Quantity, o.Priority })
					.OrderByDescending(o => o.Priority)
					.ToList();

				if (siparisdataGridView.InvokeRequired)
				{
					siparisdataGridView.Invoke(new Action(() =>
					{
						siparisdataGridView.DataSource = dataSource;
					}));
				}
				else
				{
					siparisdataGridView.DataSource = dataSource;
				}
			}
		}

		private string GetProductNameById(int productId)
		{
			string productName = "Bilinmeyen Ürün";
			string query = "SELECT ProductName FROM products WHERE ProductID = @productId";

			using (MySqlConnection connection = DatabaseHelper.GetConnection())
			using (MySqlCommand command = new MySqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@productId", productId);
				connection.Open();
				var result = command.ExecuteScalar();
				if (result != null)
				{
					productName = result.ToString();
				}
			}

			return productName;
		}

		private void Frm_Musteri_FormClosing(object sender, FormClosingEventArgs e)
		{
			Frm_Giris fr =new Frm_Giris();
			fr.Show();
			this.Hide();	
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void orderProductIdTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void orderQuantityLabel_Click(object sender, EventArgs e)
		{

		}

		private void orderQuantityTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void orderProductIdLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
