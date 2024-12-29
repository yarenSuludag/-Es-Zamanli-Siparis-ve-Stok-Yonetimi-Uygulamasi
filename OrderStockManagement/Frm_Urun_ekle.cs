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
	public partial class Frm_Urun_ekle : Form
	{
		public Frm_Urun_ekle()
		{
			InitializeComponent();
		}

		private void addProductButton_Click(object sender, EventArgs e)
		{
			Form1 frmbir = (Form1)Application.OpenForms["Form1"];

			try
			{
				string productName = productNameTextBox.Text;
				int stock = int.Parse(productStockTextBox.Text);
				float price = float.Parse(productPriceTextBox.Text);

				if (string.IsNullOrWhiteSpace(productName) || stock <= 0 || price <= 0)
				{
					MessageBox.Show("Lütfen geçerli ürün bilgilerini girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string query = "INSERT INTO Products (ProductName, Stock, Price) VALUES (@productName, @stock, @price)";
				MySqlParameter[] parameters = {
					new MySqlParameter("@productName", productName),
					new MySqlParameter("@stock", stock),
					new MySqlParameter("@price", price)
				};

				DatabaseHelper.ExecuteNonQuery(query, parameters);

				frmbir.LogAction(null, "Info", $"Yeni ürün eklendi: {productName}");
				frmbir.LoadProducts();
				frmbir.LoadLogs();

				MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ürün ekleme sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
