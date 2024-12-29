using OrderStockManagement.Models;
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
	public partial class frm_urun_gun : Form
	{
		private int productid;
		public frm_urun_gun(int productID, string productName, int stock, decimal price)
		{
			InitializeComponent();
			this.productid = productID;
			
			// Ürün bilgilerini textbox'lara doldur
			productNameTextBox.Text = productName;
			productStockTextBox.Text = stock.ToString();
			productPriceTextBox.Text = price.ToString("F2");
		}

		private void editProductButton_Click(object sender, EventArgs e)
		{
			Form1 formMain = (Form1)Application.OpenForms["Form1"];
			try
			{
				string newName = productNameTextBox.Text;
				int newStock = int.Parse(productStockTextBox.Text);
				decimal newPrice = decimal.Parse(productPriceTextBox.Text);

				string query = "UPDATE Products SET ProductName = @productName, Stock = @stock, Price = @price WHERE ProductID = @productID";
				MySqlParameter[] parameters = {
			new MySqlParameter("@productName", newName),
			new MySqlParameter("@stock", newStock),
			new MySqlParameter("@price", newPrice),
			new MySqlParameter("@productID", productid)
		};

				DatabaseHelper.ExecuteNonQuery(query, parameters);

				formMain.LogAction(null, "Info", $"Ürün güncellendi: {newName}", productid);
				formMain.LoadProducts();
				formMain.LoadLogs();

				MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.Close();
				formMain.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ürün güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
