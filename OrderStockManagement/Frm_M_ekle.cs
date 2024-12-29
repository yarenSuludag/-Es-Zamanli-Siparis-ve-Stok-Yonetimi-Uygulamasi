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
	public partial class Frm_M_ekle : Form
	{
		public Frm_M_ekle()
		{
			InitializeComponent();
		}

		private void BtnMusteriEkle_Click(object sender, EventArgs e)
		{
			Form1 frmbir = (Form1)Application.OpenForms["Form1"];

			try
			{
				string customerName = customerNameTextBox.Text;
				float budget = float.Parse(customerBudgetTextBox.Text);
				string customerType = customerTypeComboBox.SelectedItem?.ToString();

				if (string.IsNullOrWhiteSpace(customerName) || budget <= 0 || string.IsNullOrWhiteSpace(customerType))
				{
					MessageBox.Show("Lütfen geçerli müşteri bilgilerini girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string query = "INSERT INTO Customers (CustomerName, Budget, CustomerType, TotalSpent) VALUES (@customerName, @budget, @customerType, 0)";
				MySqlParameter[] parameters = {
					new MySqlParameter("@customerName", customerName),
					new MySqlParameter("@budget", budget),
					new MySqlParameter("@customerType", customerType)
				};

				DatabaseHelper.ExecuteNonQuery(query, parameters);

				
				frmbir.LogAction(null, "Info", $"Yeni müşteri eklendi: {customerName}");
				frmbir.LoadCustomers();

				MessageBox.Show("Müşteri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Müşteri ekleme sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
