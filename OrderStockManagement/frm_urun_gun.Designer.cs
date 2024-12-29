namespace OrderStockManagement
{
	partial class frm_urun_gun
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.productNameTextBox = new System.Windows.Forms.TextBox();
			this.productStockTextBox = new System.Windows.Forms.TextBox();
			this.productPriceTextBox = new System.Windows.Forms.TextBox();
			this.editProductButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(63, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 41;
			this.label3.Text = "Ürün Fiyatı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "Ürün Stoğu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 16);
			this.label1.TabIndex = 39;
			this.label1.Text = "Ürün Adı:";
			// 
			// productNameTextBox
			// 
			this.productNameTextBox.Location = new System.Drawing.Point(157, 59);
			this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Size = new System.Drawing.Size(199, 22);
			this.productNameTextBox.TabIndex = 35;
			// 
			// productStockTextBox
			// 
			this.productStockTextBox.Location = new System.Drawing.Point(157, 105);
			this.productStockTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.productStockTextBox.Name = "productStockTextBox";
			this.productStockTextBox.Size = new System.Drawing.Size(199, 22);
			this.productStockTextBox.TabIndex = 36;
			// 
			// productPriceTextBox
			// 
			this.productPriceTextBox.Location = new System.Drawing.Point(157, 154);
			this.productPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.productPriceTextBox.Name = "productPriceTextBox";
			this.productPriceTextBox.Size = new System.Drawing.Size(199, 22);
			this.productPriceTextBox.TabIndex = 37;
			// 
			// editProductButton
			// 
			this.editProductButton.Location = new System.Drawing.Point(157, 184);
			this.editProductButton.Margin = new System.Windows.Forms.Padding(4);
			this.editProductButton.Name = "editProductButton";
			this.editProductButton.Size = new System.Drawing.Size(199, 37);
			this.editProductButton.TabIndex = 38;
			this.editProductButton.Text = "Ürün Güncelle";
			this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
			// 
			// frm_urun_gun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 285);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.productNameTextBox);
			this.Controls.Add(this.productStockTextBox);
			this.Controls.Add(this.productPriceTextBox);
			this.Controls.Add(this.editProductButton);
			this.Name = "frm_urun_gun";
			this.Text = "frm_urun_gun";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox productNameTextBox;
		private System.Windows.Forms.TextBox productStockTextBox;
		private System.Windows.Forms.TextBox productPriceTextBox;
		private System.Windows.Forms.Button editProductButton;
	}
}