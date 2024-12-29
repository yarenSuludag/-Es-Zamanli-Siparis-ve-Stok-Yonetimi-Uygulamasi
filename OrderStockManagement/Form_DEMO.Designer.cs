namespace OrderStockManagement
{
	partial class Form_DEMO
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
			this.label5 = new System.Windows.Forms.Label();
			this.orderCustomerIdTextBox = new System.Windows.Forms.TextBox();
			this.orderProductIdTextBox = new System.Windows.Forms.TextBox();
			this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
			this.placeOrderButton = new System.Windows.Forms.Button();
			this.orderCustomerIdLabel = new System.Windows.Forms.Label();
			this.orderProductIdLabel = new System.Windows.Forms.Label();
			this.orderQuantityLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(327, 88);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 28);
			this.label5.TabIndex = 35;
			this.label5.Text = "aşağıdaki silinecek bi sn ";
			// 
			// orderCustomerIdTextBox
			// 
			this.orderCustomerIdTextBox.Location = new System.Drawing.Point(392, 278);
			this.orderCustomerIdTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderCustomerIdTextBox.Name = "orderCustomerIdTextBox";
			this.orderCustomerIdTextBox.Size = new System.Drawing.Size(82, 22);
			this.orderCustomerIdTextBox.TabIndex = 31;
			// 
			// orderProductIdTextBox
			// 
			this.orderProductIdTextBox.Location = new System.Drawing.Point(392, 221);
			this.orderProductIdTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderProductIdTextBox.Name = "orderProductIdTextBox";
			this.orderProductIdTextBox.Size = new System.Drawing.Size(82, 22);
			this.orderProductIdTextBox.TabIndex = 32;
			// 
			// orderQuantityTextBox
			// 
			this.orderQuantityTextBox.Location = new System.Drawing.Point(392, 162);
			this.orderQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.orderQuantityTextBox.Name = "orderQuantityTextBox";
			this.orderQuantityTextBox.Size = new System.Drawing.Size(82, 22);
			this.orderQuantityTextBox.TabIndex = 33;
			// 
			// placeOrderButton
			// 
			this.placeOrderButton.Location = new System.Drawing.Point(336, 324);
			this.placeOrderButton.Margin = new System.Windows.Forms.Padding(4);
			this.placeOrderButton.Name = "placeOrderButton";
			this.placeOrderButton.Size = new System.Drawing.Size(138, 38);
			this.placeOrderButton.TabIndex = 34;
			this.placeOrderButton.Text = "Sipariş Ver";
			this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
			// 
			// orderCustomerIdLabel
			// 
			this.orderCustomerIdLabel.Location = new System.Drawing.Point(311, 282);
			this.orderCustomerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderCustomerIdLabel.Name = "orderCustomerIdLabel";
			this.orderCustomerIdLabel.Size = new System.Drawing.Size(73, 77);
			this.orderCustomerIdLabel.TabIndex = 36;
			this.orderCustomerIdLabel.Text = "Müşteri ID:";
			// 
			// orderProductIdLabel
			// 
			this.orderProductIdLabel.Location = new System.Drawing.Point(327, 218);
			this.orderProductIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderProductIdLabel.Name = "orderProductIdLabel";
			this.orderProductIdLabel.Size = new System.Drawing.Size(57, 77);
			this.orderProductIdLabel.TabIndex = 37;
			this.orderProductIdLabel.Text = "Ürün ID:";
			// 
			// orderQuantityLabel
			// 
			this.orderQuantityLabel.Location = new System.Drawing.Point(333, 162);
			this.orderQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderQuantityLabel.Name = "orderQuantityLabel";
			this.orderQuantityLabel.Size = new System.Drawing.Size(45, 77);
			this.orderQuantityLabel.TabIndex = 38;
			this.orderQuantityLabel.Text = "Miktar:";
			// 
			// Form_DEMO
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.orderCustomerIdLabel);
			this.Controls.Add(this.orderProductIdLabel);
			this.Controls.Add(this.orderQuantityLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.orderCustomerIdTextBox);
			this.Controls.Add(this.orderProductIdTextBox);
			this.Controls.Add(this.orderQuantityTextBox);
			this.Controls.Add(this.placeOrderButton);
			this.Name = "Form_DEMO";
			this.Text = "Form_DEMO";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox orderCustomerIdTextBox;
		private System.Windows.Forms.TextBox orderProductIdTextBox;
		private System.Windows.Forms.TextBox orderQuantityTextBox;
		private System.Windows.Forms.Button placeOrderButton;
		private System.Windows.Forms.Label orderCustomerIdLabel;
		private System.Windows.Forms.Label orderProductIdLabel;
		private System.Windows.Forms.Label orderQuantityLabel;
	}
}