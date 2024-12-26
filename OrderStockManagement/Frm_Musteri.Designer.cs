namespace OrderStockManagement
{
	partial class Frm_Musteri
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.productLabel = new System.Windows.Forms.Label();
			this.m_productsGridView = new System.Windows.Forms.DataGridView();
			this.Lbl_ID = new System.Windows.Forms.Label();
			this.orderProductIdLabel = new System.Windows.Forms.Label();
			this.orderProductIdTextBox = new System.Windows.Forms.TextBox();
			this.orderQuantityLabel = new System.Windows.Forms.Label();
			this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
			this.placeOrderButton = new System.Windows.Forms.Button();
			this.siparisdataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LblNo = new System.Windows.Forms.Label();
			this.Lbl_Ad = new System.Windows.Forms.Label();
			this.LblAd = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.m_productsGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siparisdataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// productLabel
			// 
			this.productLabel.Location = new System.Drawing.Point(26, 124);
			this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(133, 28);
			this.productLabel.TabIndex = 14;
			this.productLabel.Text = "Ürün Listesi";
			// 
			// m_productsGridView
			// 
			this.m_productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.m_productsGridView.ColumnHeadersHeight = 29;
			this.m_productsGridView.Location = new System.Drawing.Point(29, 156);
			this.m_productsGridView.Margin = new System.Windows.Forms.Padding(4);
			this.m_productsGridView.Name = "m_productsGridView";
			this.m_productsGridView.RowHeadersWidth = 51;
			this.m_productsGridView.Size = new System.Drawing.Size(753, 185);
			this.m_productsGridView.TabIndex = 15;
			// 
			// Lbl_ID
			// 
			this.Lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Lbl_ID.Location = new System.Drawing.Point(7, 38);
			this.Lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_ID.Name = "Lbl_ID";
			this.Lbl_ID.Size = new System.Drawing.Size(89, 28);
			this.Lbl_ID.TabIndex = 25;
			this.Lbl_ID.Text = "Müşteri ID :";
			// 
			// orderProductIdLabel
			// 
			this.orderProductIdLabel.Location = new System.Drawing.Point(83, 419);
			this.orderProductIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderProductIdLabel.Name = "orderProductIdLabel";
			this.orderProductIdLabel.Size = new System.Drawing.Size(56, 26);
			this.orderProductIdLabel.TabIndex = 27;
			this.orderProductIdLabel.Text = "Ürün ID:";
			this.orderProductIdLabel.Click += new System.EventHandler(this.orderProductIdLabel_Click);
			// 
			// orderProductIdTextBox
			// 
			this.orderProductIdTextBox.Location = new System.Drawing.Point(154, 419);
			this.orderProductIdTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderProductIdTextBox.Name = "orderProductIdTextBox";
			this.orderProductIdTextBox.Size = new System.Drawing.Size(132, 22);
			this.orderProductIdTextBox.TabIndex = 28;
			this.orderProductIdTextBox.TextChanged += new System.EventHandler(this.orderProductIdTextBox_TextChanged);
			// 
			// orderQuantityLabel
			// 
			this.orderQuantityLabel.Location = new System.Drawing.Point(83, 452);
			this.orderQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderQuantityLabel.Name = "orderQuantityLabel";
			this.orderQuantityLabel.Size = new System.Drawing.Size(44, 26);
			this.orderQuantityLabel.TabIndex = 29;
			this.orderQuantityLabel.Text = "Miktar:";
			this.orderQuantityLabel.Click += new System.EventHandler(this.orderQuantityLabel_Click);
			// 
			// orderQuantityTextBox
			// 
			this.orderQuantityTextBox.Location = new System.Drawing.Point(154, 449);
			this.orderQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderQuantityTextBox.Name = "orderQuantityTextBox";
			this.orderQuantityTextBox.Size = new System.Drawing.Size(132, 22);
			this.orderQuantityTextBox.TabIndex = 30;
			this.orderQuantityTextBox.TextChanged += new System.EventHandler(this.orderQuantityTextBox_TextChanged);
			// 
			// placeOrderButton
			// 
			this.placeOrderButton.Location = new System.Drawing.Point(86, 493);
			this.placeOrderButton.Margin = new System.Windows.Forms.Padding(4);
			this.placeOrderButton.Name = "placeOrderButton";
			this.placeOrderButton.Size = new System.Drawing.Size(200, 35);
			this.placeOrderButton.TabIndex = 31;
			this.placeOrderButton.Text = "Sipariş Ver";
			this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click_1);
			// 
			// siparisdataGridView
			// 
			this.siparisdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.siparisdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.siparisdataGridView.Location = new System.Drawing.Point(325, 394);
			this.siparisdataGridView.Name = "siparisdataGridView";
			this.siparisdataGridView.RowHeadersWidth = 51;
			this.siparisdataGridView.RowTemplate.Height = 24;
			this.siparisdataGridView.Size = new System.Drawing.Size(457, 150);
			this.siparisdataGridView.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(322, 363);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 28);
			this.label1.TabIndex = 33;
			this.label1.Text = "Sipariş Detay";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LblAd);
			this.groupBox1.Controls.Add(this.Lbl_Ad);
			this.groupBox1.Controls.Add(this.LblNo);
			this.groupBox1.Controls.Add(this.Lbl_ID);
			this.groupBox1.Location = new System.Drawing.Point(30, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(631, 89);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteri Bilgi";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// LblNo
			// 
			this.LblNo.Location = new System.Drawing.Point(98, 38);
			this.LblNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblNo.Name = "LblNo";
			this.LblNo.Size = new System.Drawing.Size(72, 28);
			this.LblNo.TabIndex = 26;
			this.LblNo.Text = "00000";
			// 
			// Lbl_Ad
			// 
			this.Lbl_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Lbl_Ad.Location = new System.Drawing.Point(166, 38);
			this.Lbl_Ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Lbl_Ad.Name = "Lbl_Ad";
			this.Lbl_Ad.Size = new System.Drawing.Size(72, 28);
			this.Lbl_Ad.TabIndex = 27;
			this.Lbl_Ad.Text = "Adı:";
			// 
			// LblAd
			// 
			this.LblAd.Location = new System.Drawing.Point(200, 38);
			this.LblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblAd.Name = "LblAd";
			this.LblAd.Size = new System.Drawing.Size(72, 28);
			this.LblAd.TabIndex = 29;
			this.LblAd.Text = "00000";
			// 
			// Frm_Musteri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 577);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.siparisdataGridView);
			this.Controls.Add(this.orderProductIdLabel);
			this.Controls.Add(this.orderProductIdTextBox);
			this.Controls.Add(this.orderQuantityLabel);
			this.Controls.Add(this.orderQuantityTextBox);
			this.Controls.Add(this.placeOrderButton);
			this.Controls.Add(this.productLabel);
			this.Controls.Add(this.m_productsGridView);
			this.Name = "Frm_Musteri";
			this.Text = "Frm_Musteri";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Musteri_FormClosing);
			this.Load += new System.EventHandler(this.Frm_Musteri_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_productsGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siparisdataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label productLabel;
		private System.Windows.Forms.DataGridView m_productsGridView;
		private System.Windows.Forms.Label Lbl_ID;
		private System.Windows.Forms.Label orderProductIdLabel;
		private System.Windows.Forms.TextBox orderProductIdTextBox;
		private System.Windows.Forms.Label orderQuantityLabel;
		private System.Windows.Forms.TextBox orderQuantityTextBox;
		private System.Windows.Forms.Button placeOrderButton;
		private System.Windows.Forms.DataGridView siparisdataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label Lbl_Ad;
		private System.Windows.Forms.Label LblNo;
		private System.Windows.Forms.Label LblAd;
	}
}