using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OrderStockManagement.Models;

namespace OrderStockManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
            LoadLogs();
        }

        private void LoadCustomers()
        {
            string query = "SELECT * FROM Customers";
            customersGridView.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void LoadProducts()
        {
            string query = "SELECT * FROM Products";
            productsGridView.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void LoadLogs()
        {
            string query = "SELECT * FROM Logs ORDER BY LogDate DESC";
            logsGridView.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(orderCustomerIdTextBox.Text);
            int productId = int.Parse(orderProductIdTextBox.Text);
            int quantity = int.Parse(orderQuantityTextBox.Text);

            string productQuery = "SELECT Stock, Price FROM Products WHERE ProductID = @productId";
            MySqlParameter[] productParameters = { new MySqlParameter("@productId", productId) };
            DataTable productData = DatabaseHelper.ExecuteQuery(productQuery, productParameters);

            int stock = Convert.ToInt32(productData.Rows[0]["Stock"]);
            float price = Convert.ToSingle(productData.Rows[0]["Price"]);
            float totalPrice = price * quantity;

            string customerQuery = "SELECT Budget, CustomerType FROM Customers WHERE CustomerID = @customerId";
            MySqlParameter[] customerParameters = { new MySqlParameter("@customerId", customerId) };
            DataTable customerData = DatabaseHelper.ExecuteQuery(customerQuery, customerParameters);

            float budget = Convert.ToSingle(customerData.Rows[0]["Budget"]);
            string customerType = customerData.Rows[0]["CustomerType"].ToString();

            if (quantity > stock)
            {
                LogAction(customerId, "Hata", "Yetersiz Stok");
                MessageBox.Show("Yetersiz stok!");
                return;
            }

            if (totalPrice > budget)
            {
                LogAction(customerId, "Hata", "Yetersiz Bütçe");
                MessageBox.Show("Yetersiz bütçe!");
                return;
            }

            string updateStockQuery = "UPDATE Products SET Stock = Stock - @quantity WHERE ProductID = @productId";
            DatabaseHelper.ExecuteNonQuery(updateStockQuery, productParameters);

            string updateBudgetQuery = "UPDATE Customers SET Budget = Budget - @totalPrice WHERE CustomerID = @customerId";
            MySqlParameter[] budgetParams = {
                new MySqlParameter("@totalPrice", totalPrice),
                new MySqlParameter("@customerId", customerId)
            };
            DatabaseHelper.ExecuteNonQuery(updateBudgetQuery, budgetParams);

            LogAction(customerId, "Bilgi", "Sipariş Başarılı");
            MessageBox.Show("Sipariş tamamlandı!");
            LoadProducts();
            LoadLogs();
        }



        private void AddProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan ürün bilgilerini al
                string productName = productNameTextBox.Text;
                int stock = int.Parse(productStockTextBox.Text);
                float price = float.Parse(productPriceTextBox.Text);

                // Alanların boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(productName) || stock <= 0 || price <= 0)
                {
                    MessageBox.Show("Lütfen geçerli ürün bilgilerini girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ürün ekleme SQL sorgusu
                string query = "INSERT INTO Products (ProductName, Stock, Price) VALUES (@productName, @stock, @price)";
                MySqlParameter[] parameters = {
            new MySqlParameter("@productName", productName),
            new MySqlParameter("@stock", stock),
            new MySqlParameter("@price", price)
        };

                // Sorguyu çalıştır
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                // Başarı mesajı ve tabloyu güncelle
                LogAction(null, "Bilgi", $"Yeni ürün eklendi: {productName}");
                MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts(); // Ürün listesini güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan müşteri bilgilerini al
                string customerName = customerNameTextBox.Text;
                float budget = float.Parse(customerBudgetTextBox.Text);
                string customerType = customerTypeComboBox.SelectedItem?.ToString();

                // Alanların boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(customerName) || budget <= 0 || string.IsNullOrWhiteSpace(customerType))
                {
                    MessageBox.Show("Lütfen geçerli müşteri bilgilerini girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Müşteri ekleme SQL sorgusu
                string query = "INSERT INTO Customers (CustomerName, Budget, CustomerType, TotalSpent) " +
                               "VALUES (@customerName, @budget, @customerType, 0)";
                MySqlParameter[] parameters = {
            new MySqlParameter("@customerName", customerName),
            new MySqlParameter("@budget", budget),
            new MySqlParameter("@customerType", customerType)
        };

                // Sorguyu çalıştır
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                // Başarı mesajı ve tabloyu güncelle
                LogAction(null, "Bilgi", $"Yeni müşteri eklendi: {customerName} ({customerType})");
                MessageBox.Show("Müşteri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomers(); // Müşteri listesini güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private void LogAction(int? customerId, string logType, string details)
        {
            string query = "INSERT INTO Logs (CustomerID, LogType, LogDetails) VALUES (@customerId, @logType, @details)";
            MySqlParameter[] parameters = {
        new MySqlParameter("@customerId", customerId.HasValue ? (object)customerId.Value : DBNull.Value),
        new MySqlParameter("@logType", logType),
        new MySqlParameter("@details", details)
    };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
