namespace OrderStockManagement
{
    partial class Form1
    {
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridView logsGridView;

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label logLabel;

        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button placeOrderButton;

        private System.Windows.Forms.Label orderCustomerIdLabel;
        private System.Windows.Forms.TextBox orderCustomerIdTextBox;

        private System.Windows.Forms.Label orderProductIdLabel;
        private System.Windows.Forms.TextBox orderProductIdTextBox;

        private System.Windows.Forms.Label orderQuantityLabel;
        private System.Windows.Forms.TextBox orderQuantityTextBox;

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productStockTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerBudgetTextBox;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerBudgetLabel;
        private System.Windows.Forms.Label customerTypeLabel;


        /// <summary>
        /// Gerekli bileşenler temizlenir.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Form bileşenlerini başlat.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.productLabel = new System.Windows.Forms.Label();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.logLabel = new System.Windows.Forms.Label();
            this.logsGridView = new System.Windows.Forms.DataGridView();
            this.orderCustomerIdLabel = new System.Windows.Forms.Label();
            this.orderCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.orderProductIdLabel = new System.Windows.Forms.Label();
            this.orderProductIdTextBox = new System.Windows.Forms.TextBox();
            this.orderQuantityLabel = new System.Windows.Forms.Label();
            this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productStockTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerBudgetLabel = new System.Windows.Forms.Label();
            this.customerBudgetTextBox = new System.Windows.Forms.TextBox();
            this.customerTypeLabel = new System.Windows.Forms.Label();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(250, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(400, 30);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Eş Zamanlı Sipariş ve Stok Yönetimi";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.Location = new System.Drawing.Point(20, 50);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(100, 23);
            this.customerLabel.TabIndex = 10;
            this.customerLabel.Text = "Müşteri Listesi";
            // 
            // customersGridView
            // 
            this.customersGridView.Location = new System.Drawing.Point(20, 80);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.Size = new System.Drawing.Size(350, 150);
            this.customersGridView.TabIndex = 11;
            // 
            // productLabel
            // 
            this.productLabel.Location = new System.Drawing.Point(400, 50);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(100, 23);
            this.productLabel.TabIndex = 12;
            this.productLabel.Text = "Ürün Listesi";
            // 
            // productsGridView
            // 
            this.productsGridView.Location = new System.Drawing.Point(400, 80);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.Size = new System.Drawing.Size(350, 150);
            this.productsGridView.TabIndex = 13;
            // 
            // logLabel
            // 
            this.logLabel.Location = new System.Drawing.Point(20, 250);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(100, 23);
            this.logLabel.TabIndex = 14;
            this.logLabel.Text = "Loglar";
            // 
            // logsGridView
            // 
            this.logsGridView.Location = new System.Drawing.Point(20, 280);
            this.logsGridView.Name = "logsGridView";
            this.logsGridView.Size = new System.Drawing.Size(730, 150);
            this.logsGridView.TabIndex = 15;
            // 
            // orderCustomerIdLabel
            // 
            this.orderCustomerIdLabel.Location = new System.Drawing.Point(20, 450);
            this.orderCustomerIdLabel.Name = "orderCustomerIdLabel";
            this.orderCustomerIdLabel.Size = new System.Drawing.Size(100, 23);
            this.orderCustomerIdLabel.TabIndex = 16;
            this.orderCustomerIdLabel.Text = "Müşteri ID:";
            // 
            // orderCustomerIdTextBox
            // 
            this.orderCustomerIdTextBox.Location = new System.Drawing.Point(100, 450);
            this.orderCustomerIdTextBox.Name = "orderCustomerIdTextBox";
            this.orderCustomerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderCustomerIdTextBox.TabIndex = 17;
            // 
            // orderProductIdLabel
            // 
            this.orderProductIdLabel.Location = new System.Drawing.Point(220, 450);
            this.orderProductIdLabel.Name = "orderProductIdLabel";
            this.orderProductIdLabel.Size = new System.Drawing.Size(100, 23);
            this.orderProductIdLabel.TabIndex = 18;
            this.orderProductIdLabel.Text = "Ürün ID:";
            // 
            // orderProductIdTextBox
            // 
            this.orderProductIdTextBox.Location = new System.Drawing.Point(300, 450);
            this.orderProductIdTextBox.Name = "orderProductIdTextBox";
            this.orderProductIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderProductIdTextBox.TabIndex = 19;
            // 
            // orderQuantityLabel
            // 
            this.orderQuantityLabel.Location = new System.Drawing.Point(420, 450);
            this.orderQuantityLabel.Name = "orderQuantityLabel";
            this.orderQuantityLabel.Size = new System.Drawing.Size(100, 23);
            this.orderQuantityLabel.TabIndex = 20;
            this.orderQuantityLabel.Text = "Miktar:";
            // 
            // orderQuantityTextBox
            // 
            this.orderQuantityTextBox.Location = new System.Drawing.Point(500, 450);
            this.orderQuantityTextBox.Name = "orderQuantityTextBox";
            this.orderQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderQuantityTextBox.TabIndex = 21;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(450, 240);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.productNameTextBox.TabIndex = 0;
            // 
            // productStockTextBox
            // 
            this.productStockTextBox.Location = new System.Drawing.Point(450, 280);
            this.productStockTextBox.Name = "productStockTextBox";
            this.productStockTextBox.Size = new System.Drawing.Size(150, 20);
            this.productStockTextBox.TabIndex = 1;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(450, 320);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(150, 20);
            this.productPriceTextBox.TabIndex = 2;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Location = new System.Drawing.Point(20, 240);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(100, 20);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Müşteri Adı:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(120, 240);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // customerBudgetLabel
            // 
            this.customerBudgetLabel.Location = new System.Drawing.Point(20, 280);
            this.customerBudgetLabel.Name = "customerBudgetLabel";
            this.customerBudgetLabel.Size = new System.Drawing.Size(100, 20);
            this.customerBudgetLabel.TabIndex = 5;
            this.customerBudgetLabel.Text = "Bütçe:";
            // 
            // customerBudgetTextBox
            // 
            this.customerBudgetTextBox.Location = new System.Drawing.Point(120, 280);
            this.customerBudgetTextBox.Name = "customerBudgetTextBox";
            this.customerBudgetTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerBudgetTextBox.TabIndex = 6;
            // 
            // customerTypeLabel
            // 
            this.customerTypeLabel.Location = new System.Drawing.Point(20, 320);
            this.customerTypeLabel.Name = "customerTypeLabel";
            this.customerTypeLabel.Size = new System.Drawing.Size(100, 20);
            this.customerTypeLabel.TabIndex = 7;
            this.customerTypeLabel.Text = "Müşteri Türü:";
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Premium",
            "Standard"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(120, 320);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(150, 21);
            this.customerTypeComboBox.TabIndex = 8;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(20, 500);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(150, 30);
            this.addCustomerButton.TabIndex = 22;
            this.addCustomerButton.Text = "Müşteri Ekle";
            this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(200, 500);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(150, 30);
            this.addProductButton.TabIndex = 23;
            this.addProductButton.Text = "Ürün Ekle";
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Location = new System.Drawing.Point(400, 500);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(150, 30);
            this.placeOrderButton.TabIndex = 24;
            this.placeOrderButton.Text = "Sipariş Ver";
            this.placeOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productStockTextBox);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerBudgetLabel);
            this.Controls.Add(this.customerBudgetTextBox);
            this.Controls.Add(this.customerTypeLabel);
            this.Controls.Add(this.customerTypeComboBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.customersGridView);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logsGridView);
            this.Controls.Add(this.orderCustomerIdLabel);
            this.Controls.Add(this.orderCustomerIdTextBox);
            this.Controls.Add(this.orderProductIdLabel);
            this.Controls.Add(this.orderProductIdTextBox);
            this.Controls.Add(this.orderQuantityLabel);
            this.Controls.Add(this.orderQuantityTextBox);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.placeOrderButton);
            this.Name = "Form1";
            this.Text = "Sipariş ve Stok Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
