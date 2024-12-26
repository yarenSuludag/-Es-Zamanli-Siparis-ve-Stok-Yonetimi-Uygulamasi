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

        private System.Windows.Forms.DataGridView orderQueueGridView;




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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.orderQueueGridView = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logsGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderQueueGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.titleLabel.Location = new System.Drawing.Point(331, 9);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(533, 37);
			this.titleLabel.TabIndex = 9;
			this.titleLabel.Text = "Eş Zamanlı Sipariş ve Stok Yönetimi";
			this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
			// 
			// customerLabel
			// 
			this.customerLabel.Location = new System.Drawing.Point(27, 62);
			this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(133, 28);
			this.customerLabel.TabIndex = 10;
			this.customerLabel.Text = "Müşteri Listesi";
			// 
			// customersGridView
			// 
			this.customersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.customersGridView.ColumnHeadersHeight = 29;
			this.customersGridView.Location = new System.Drawing.Point(27, 98);
			this.customersGridView.Margin = new System.Windows.Forms.Padding(4);
			this.customersGridView.Name = "customersGridView";
			this.customersGridView.RowHeadersWidth = 51;
			this.customersGridView.Size = new System.Drawing.Size(513, 185);
			this.customersGridView.TabIndex = 11;
			this.customersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGridView_CellContentClick);
			// 
			// productLabel
			// 
			this.productLabel.Location = new System.Drawing.Point(571, 62);
			this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(133, 28);
			this.productLabel.TabIndex = 12;
			this.productLabel.Text = "Ürün Listesi";
			// 
			// productsGridView
			// 
			this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.productsGridView.ColumnHeadersHeight = 29;
			this.productsGridView.Location = new System.Drawing.Point(574, 94);
			this.productsGridView.Margin = new System.Windows.Forms.Padding(4);
			this.productsGridView.Name = "productsGridView";
			this.productsGridView.RowHeadersWidth = 51;
			this.productsGridView.Size = new System.Drawing.Size(467, 185);
			this.productsGridView.TabIndex = 13;
			// 
			// logLabel
			// 
			this.logLabel.Location = new System.Drawing.Point(27, 481);
			this.logLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.logLabel.Name = "logLabel";
			this.logLabel.Size = new System.Drawing.Size(133, 28);
			this.logLabel.TabIndex = 14;
			this.logLabel.Text = "Loglar";
			this.logLabel.Click += new System.EventHandler(this.logLabel_Click);
			// 
			// logsGridView
			// 
			this.logsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.logsGridView.ColumnHeadersHeight = 29;
			this.logsGridView.Location = new System.Drawing.Point(27, 513);
			this.logsGridView.Margin = new System.Windows.Forms.Padding(4);
			this.logsGridView.Name = "logsGridView";
			this.logsGridView.RowHeadersWidth = 51;
			this.logsGridView.Size = new System.Drawing.Size(737, 212);
			this.logsGridView.TabIndex = 15;
			// 
			// orderCustomerIdLabel
			// 
			this.orderCustomerIdLabel.Location = new System.Drawing.Point(1051, 237);
			this.orderCustomerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderCustomerIdLabel.Name = "orderCustomerIdLabel";
			this.orderCustomerIdLabel.Size = new System.Drawing.Size(73, 77);
			this.orderCustomerIdLabel.TabIndex = 16;
			this.orderCustomerIdLabel.Text = "Müşteri ID:";
			this.orderCustomerIdLabel.Click += new System.EventHandler(this.orderCustomerIdLabel_Click);
			// 
			// orderCustomerIdTextBox
			// 
			this.orderCustomerIdTextBox.Location = new System.Drawing.Point(1132, 234);
			this.orderCustomerIdTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderCustomerIdTextBox.Name = "orderCustomerIdTextBox";
			this.orderCustomerIdTextBox.Size = new System.Drawing.Size(82, 22);
			this.orderCustomerIdTextBox.TabIndex = 17;
			// 
			// orderProductIdLabel
			// 
			this.orderProductIdLabel.Location = new System.Drawing.Point(1067, 177);
			this.orderProductIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderProductIdLabel.Name = "orderProductIdLabel";
			this.orderProductIdLabel.Size = new System.Drawing.Size(57, 77);
			this.orderProductIdLabel.TabIndex = 18;
			this.orderProductIdLabel.Text = "Ürün ID:";
			// 
			// orderProductIdTextBox
			// 
			this.orderProductIdTextBox.Location = new System.Drawing.Point(1132, 177);
			this.orderProductIdTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderProductIdTextBox.Name = "orderProductIdTextBox";
			this.orderProductIdTextBox.Size = new System.Drawing.Size(82, 22);
			this.orderProductIdTextBox.TabIndex = 19;
			// 
			// orderQuantityLabel
			// 
			this.orderQuantityLabel.Location = new System.Drawing.Point(1073, 121);
			this.orderQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderQuantityLabel.Name = "orderQuantityLabel";
			this.orderQuantityLabel.Size = new System.Drawing.Size(45, 77);
			this.orderQuantityLabel.TabIndex = 20;
			this.orderQuantityLabel.Text = "Miktar:";
			// 
			// orderQuantityTextBox
			// 
			this.orderQuantityTextBox.Location = new System.Drawing.Point(1132, 118);
			this.orderQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderQuantityTextBox.Name = "orderQuantityTextBox";
			this.orderQuantityTextBox.Size = new System.Drawing.Size(82, 22);
			this.orderQuantityTextBox.TabIndex = 21;
			// 
			// productNameTextBox
			// 
			this.productNameTextBox.Location = new System.Drawing.Point(679, 302);
			this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Size = new System.Drawing.Size(199, 22);
			this.productNameTextBox.TabIndex = 0;
			this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
			// 
			// productStockTextBox
			// 
			this.productStockTextBox.Location = new System.Drawing.Point(679, 348);
			this.productStockTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.productStockTextBox.Name = "productStockTextBox";
			this.productStockTextBox.Size = new System.Drawing.Size(199, 22);
			this.productStockTextBox.TabIndex = 1;
			this.productStockTextBox.TextChanged += new System.EventHandler(this.productStockTextBox_TextChanged);
			// 
			// productPriceTextBox
			// 
			this.productPriceTextBox.Location = new System.Drawing.Point(679, 397);
			this.productPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.productPriceTextBox.Name = "productPriceTextBox";
			this.productPriceTextBox.Size = new System.Drawing.Size(199, 22);
			this.productPriceTextBox.TabIndex = 2;
			this.productPriceTextBox.TextChanged += new System.EventHandler(this.productPriceTextBox_TextChanged);
			// 
			// customerNameLabel
			// 
			this.customerNameLabel.Location = new System.Drawing.Point(142, 305);
			this.customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerNameLabel.Name = "customerNameLabel";
			this.customerNameLabel.Size = new System.Drawing.Size(81, 25);
			this.customerNameLabel.TabIndex = 3;
			this.customerNameLabel.Text = "Müşteri Adı:";
			this.customerNameLabel.Click += new System.EventHandler(this.customerNameLabel_Click);
			// 
			// customerNameTextBox
			// 
			this.customerNameTextBox.Location = new System.Drawing.Point(222, 305);
			this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.customerNameTextBox.Name = "customerNameTextBox";
			this.customerNameTextBox.Size = new System.Drawing.Size(199, 22);
			this.customerNameTextBox.TabIndex = 4;
			this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
			// 
			// customerBudgetLabel
			// 
			this.customerBudgetLabel.Location = new System.Drawing.Point(142, 342);
			this.customerBudgetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerBudgetLabel.Name = "customerBudgetLabel";
			this.customerBudgetLabel.Size = new System.Drawing.Size(79, 25);
			this.customerBudgetLabel.TabIndex = 5;
			this.customerBudgetLabel.Text = "Bütçe:";
			// 
			// customerBudgetTextBox
			// 
			this.customerBudgetTextBox.Location = new System.Drawing.Point(222, 345);
			this.customerBudgetTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.customerBudgetTextBox.Name = "customerBudgetTextBox";
			this.customerBudgetTextBox.Size = new System.Drawing.Size(199, 22);
			this.customerBudgetTextBox.TabIndex = 6;
			this.customerBudgetTextBox.TextChanged += new System.EventHandler(this.customerBudgetTextBox_TextChanged);
			// 
			// customerTypeLabel
			// 
			this.customerTypeLabel.Location = new System.Drawing.Point(137, 390);
			this.customerTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerTypeLabel.Name = "customerTypeLabel";
			this.customerTypeLabel.Size = new System.Drawing.Size(84, 25);
			this.customerTypeLabel.TabIndex = 7;
			this.customerTypeLabel.Text = "Müşteri Türü:";
			// 
			// customerTypeComboBox
			// 
			this.customerTypeComboBox.Items.AddRange(new object[] {
            "Premium",
            "Standard"});
			this.customerTypeComboBox.Location = new System.Drawing.Point(222, 391);
			this.customerTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.customerTypeComboBox.Name = "customerTypeComboBox";
			this.customerTypeComboBox.Size = new System.Drawing.Size(199, 24);
			this.customerTypeComboBox.TabIndex = 8;
			this.customerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.customerTypeComboBox_SelectedIndexChanged);
			// 
			// addCustomerButton
			// 
			this.addCustomerButton.Location = new System.Drawing.Point(222, 427);
			this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4);
			this.addCustomerButton.Name = "addCustomerButton";
			this.addCustomerButton.Size = new System.Drawing.Size(199, 37);
			this.addCustomerButton.TabIndex = 22;
			this.addCustomerButton.Text = "Müşteri Ekle";
			this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
			// 
			// addProductButton
			// 
			this.addProductButton.Location = new System.Drawing.Point(679, 427);
			this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
			this.addProductButton.Name = "addProductButton";
			this.addProductButton.Size = new System.Drawing.Size(199, 37);
			this.addProductButton.TabIndex = 23;
			this.addProductButton.Text = "Ürün Ekle";
			this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
			// 
			// placeOrderButton
			// 
			this.placeOrderButton.Location = new System.Drawing.Point(1076, 280);
			this.placeOrderButton.Margin = new System.Windows.Forms.Padding(4);
			this.placeOrderButton.Name = "placeOrderButton";
			this.placeOrderButton.Size = new System.Drawing.Size(138, 38);
			this.placeOrderButton.TabIndex = 24;
			this.placeOrderButton.Text = "Sipariş Ver";
			this.placeOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(585, 302);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 16);
			this.label1.TabIndex = 25;
			this.label1.Text = "Ürün Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(585, 354);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 26;
			this.label2.Text = "Ürün Stoğu:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(585, 400);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 27;
			this.label3.Text = "Ürün Fiyatı:";
			// 
			// orderQueueGridView
			// 
			this.orderQueueGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.orderQueueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderQueueGridView.Location = new System.Drawing.Point(848, 513);
			this.orderQueueGridView.Name = "orderQueueGridView";
			this.orderQueueGridView.RowHeadersWidth = 51;
			this.orderQueueGridView.Size = new System.Drawing.Size(255, 212);
			this.orderQueueGridView.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(845, 482);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 28);
			this.label4.TabIndex = 29;
			this.label4.Text = "Sipariş Sırası";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(1067, 44);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 28);
			this.label5.TabIndex = 30;
			this.label5.Text = "aşağıdaki silinecek bi sn ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1250, 738);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.orderQueueGridView);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Sipariş ve Stok Yönetimi";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logsGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderQueueGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}
