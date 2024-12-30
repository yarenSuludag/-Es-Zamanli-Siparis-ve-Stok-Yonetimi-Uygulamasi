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

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.DataGridView orderQueueGridView;

        private System.Windows.Forms.Button approveAllButton;



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
			this.addCustomerButton = new System.Windows.Forms.Button();
			this.addProductButton = new System.Windows.Forms.Button();
			this.orderQueueGridView = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.editProductButton = new System.Windows.Forms.Button();
			this.deleteProductButton = new System.Windows.Forms.Button();
			this.BtnOnay = new System.Windows.Forms.Button();
			this.BtnIptal = new System.Windows.Forms.Button();
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
			this.customersGridView.Size = new System.Drawing.Size(607, 185);
			this.customersGridView.TabIndex = 11;
			this.customersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGridView_CellContentClick);
			// 
			// productLabel
			// 
			this.productLabel.Location = new System.Drawing.Point(645, 66);
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
			this.productsGridView.Location = new System.Drawing.Point(648, 98);
			this.productsGridView.Margin = new System.Windows.Forms.Padding(4);
			this.productsGridView.Name = "productsGridView";
			this.productsGridView.RowHeadersWidth = 51;
			this.productsGridView.Size = new System.Drawing.Size(574, 185);
			this.productsGridView.TabIndex = 13;
			// 
			// logLabel
			// 
			this.logLabel.Location = new System.Drawing.Point(19, 392);
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
			this.logsGridView.Location = new System.Drawing.Point(19, 424);
			this.logsGridView.Margin = new System.Windows.Forms.Padding(4);
			this.logsGridView.Name = "logsGridView";
			this.logsGridView.RowHeadersWidth = 51;
			this.logsGridView.Size = new System.Drawing.Size(615, 212);
			this.logsGridView.TabIndex = 15;
			// 
			// addCustomerButton
			// 
			this.addCustomerButton.Location = new System.Drawing.Point(128, 302);
			this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4);
			this.addCustomerButton.Name = "addCustomerButton";
			this.addCustomerButton.Size = new System.Drawing.Size(187, 37);
			this.addCustomerButton.TabIndex = 22;
			this.addCustomerButton.Text = "Müşteri Ekle";
			this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
			// 
			// addProductButton
			// 
			this.addProductButton.Location = new System.Drawing.Point(701, 302);
			this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
			this.addProductButton.Name = "addProductButton";
			this.addProductButton.Size = new System.Drawing.Size(150, 37);
			this.addProductButton.TabIndex = 23;
			this.addProductButton.Text = "Ürün Ekle";
			this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
			// 
			// orderQueueGridView
			// 
			this.orderQueueGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.orderQueueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderQueueGridView.Location = new System.Drawing.Point(648, 424);
			this.orderQueueGridView.Name = "orderQueueGridView";
			this.orderQueueGridView.RowHeadersWidth = 51;
			this.orderQueueGridView.Size = new System.Drawing.Size(574, 212);
			this.orderQueueGridView.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(645, 393);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(452, 28);
			this.label4.TabIndex = 29;
			this.label4.Text = "Sipariş Sırası";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(337, 302);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(185, 37);
			this.button1.TabIndex = 31;
			this.button1.Text = "Müşteri Güncelle";
			this.button1.Click += new System.EventHandler(this.editCustomerButton_Click);
			// 
			// editProductButton
			// 
			this.editProductButton.Location = new System.Drawing.Point(870, 302);
			this.editProductButton.Margin = new System.Windows.Forms.Padding(4);
			this.editProductButton.Name = "editProductButton";
			this.editProductButton.Size = new System.Drawing.Size(150, 37);
			this.editProductButton.TabIndex = 32;
			this.editProductButton.Text = "Ürün Güncelle";
			this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
			// 
			// deleteProductButton
			// 
			this.deleteProductButton.Location = new System.Drawing.Point(1041, 302);
			this.deleteProductButton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteProductButton.Name = "deleteProductButton";
			this.deleteProductButton.Size = new System.Drawing.Size(150, 37);
			this.deleteProductButton.TabIndex = 33;
			this.deleteProductButton.Text = "Ürün Sil";
			this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
			// 
			// BtnOnay
			// 
			this.BtnOnay.Location = new System.Drawing.Point(729, 653);
			this.BtnOnay.Margin = new System.Windows.Forms.Padding(4);
			this.BtnOnay.Name = "BtnOnay";
			this.BtnOnay.Size = new System.Drawing.Size(201, 37);
			this.BtnOnay.TabIndex = 34;
			this.BtnOnay.Text = "Sipariş Onayla";
			// 
			// BtnIptal
			// 
			this.BtnIptal.Location = new System.Drawing.Point(949, 653);
			this.BtnIptal.Margin = new System.Windows.Forms.Padding(4);
			this.BtnIptal.Name = "BtnIptal";
			this.BtnIptal.Size = new System.Drawing.Size(197, 37);
			this.BtnIptal.TabIndex = 35;
			this.BtnIptal.Text = "Sipariş iptal";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1250, 738);
			this.Controls.Add(this.BtnIptal);
			this.Controls.Add(this.BtnOnay);
			this.Controls.Add(this.deleteProductButton);
			this.Controls.Add(this.editProductButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.orderQueueGridView);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.customersGridView);
			this.Controls.Add(this.productLabel);
			this.Controls.Add(this.productsGridView);
			this.Controls.Add(this.logLabel);
			this.Controls.Add(this.logsGridView);
			this.Controls.Add(this.addCustomerButton);
			this.Controls.Add(this.addProductButton);
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

        }
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button editProductButton;
		private System.Windows.Forms.Button deleteProductButton;
		private System.Windows.Forms.Button BtnOnay;
		private System.Windows.Forms.Button BtnIptal;
	}
}
