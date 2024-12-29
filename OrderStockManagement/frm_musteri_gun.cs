using OrderStockManagement.Models;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderStockManagement
{
    public partial class frm_musteri_gun : Form
    {
        private int customerId;

        public frm_musteri_gun(int customerId, string customerName, float budget, string customerType)
        {
            InitializeComponent();
            this.customerId = customerId;

            // Mevcut müşteri bilgilerini doldur
            customerNameTextBox.Text = customerName;
            customerBudgetTextBox.Text = budget.ToString("F2");
            customerTypeComboBox.SelectedItem = customerType;
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = customerNameTextBox.Text;
                float newBudget = float.Parse(customerBudgetTextBox.Text);
                string newType = customerTypeComboBox.SelectedItem.ToString();

                string query = "UPDATE Customers SET CustomerName = @name, Budget = @budget, CustomerType = @type WHERE CustomerID = @id";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@name", newName),
                    new MySqlParameter("@budget", newBudget),
                    new MySqlParameter("@type", newType),
                    new MySqlParameter("@id", customerId)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri güncellenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
