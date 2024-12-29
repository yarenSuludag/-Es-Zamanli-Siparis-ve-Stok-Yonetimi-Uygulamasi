namespace OrderStockManagement
{
	partial class Frm_M_ekle
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
			this.customerNameLabel = new System.Windows.Forms.Label();
			this.customerNameTextBox = new System.Windows.Forms.TextBox();
			this.customerBudgetLabel = new System.Windows.Forms.Label();
			this.customerBudgetTextBox = new System.Windows.Forms.TextBox();
			this.customerTypeLabel = new System.Windows.Forms.Label();
			this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
			this.BtnMusteriEkle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// customerNameLabel
			// 
			this.customerNameLabel.Location = new System.Drawing.Point(55, 43);
			this.customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerNameLabel.Name = "customerNameLabel";
			this.customerNameLabel.Size = new System.Drawing.Size(81, 25);
			this.customerNameLabel.TabIndex = 23;
			this.customerNameLabel.Text = "Müşteri Adı:";
			// 
			// customerNameTextBox
			// 
			this.customerNameTextBox.Location = new System.Drawing.Point(135, 43);
			this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.customerNameTextBox.Name = "customerNameTextBox";
			this.customerNameTextBox.Size = new System.Drawing.Size(199, 22);
			this.customerNameTextBox.TabIndex = 24;
			// 
			// customerBudgetLabel
			// 
			this.customerBudgetLabel.Location = new System.Drawing.Point(55, 80);
			this.customerBudgetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerBudgetLabel.Name = "customerBudgetLabel";
			this.customerBudgetLabel.Size = new System.Drawing.Size(79, 25);
			this.customerBudgetLabel.TabIndex = 25;
			this.customerBudgetLabel.Text = "Bütçe:";
			// 
			// customerBudgetTextBox
			// 
			this.customerBudgetTextBox.Location = new System.Drawing.Point(135, 83);
			this.customerBudgetTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.customerBudgetTextBox.Name = "customerBudgetTextBox";
			this.customerBudgetTextBox.Size = new System.Drawing.Size(199, 22);
			this.customerBudgetTextBox.TabIndex = 26;
			// 
			// customerTypeLabel
			// 
			this.customerTypeLabel.Location = new System.Drawing.Point(50, 128);
			this.customerTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerTypeLabel.Name = "customerTypeLabel";
			this.customerTypeLabel.Size = new System.Drawing.Size(84, 25);
			this.customerTypeLabel.TabIndex = 27;
			this.customerTypeLabel.Text = "Müşteri Türü:";
			// 
			// customerTypeComboBox
			// 
			this.customerTypeComboBox.Items.AddRange(new object[] {
            "Premium",
            "Standard"});
			this.customerTypeComboBox.Location = new System.Drawing.Point(135, 129);
			this.customerTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.customerTypeComboBox.Name = "customerTypeComboBox";
			this.customerTypeComboBox.Size = new System.Drawing.Size(199, 24);
			this.customerTypeComboBox.TabIndex = 28;
			// 
			// BtnMusteriEkle
			// 
			this.BtnMusteriEkle.Location = new System.Drawing.Point(135, 165);
			this.BtnMusteriEkle.Margin = new System.Windows.Forms.Padding(4);
			this.BtnMusteriEkle.Name = "BtnMusteriEkle";
			this.BtnMusteriEkle.Size = new System.Drawing.Size(199, 37);
			this.BtnMusteriEkle.TabIndex = 29;
			this.BtnMusteriEkle.Text = "Müşteri Ekle";
			this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
			// 
			// Frm_M_ekle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 264);
			this.Controls.Add(this.customerNameLabel);
			this.Controls.Add(this.customerNameTextBox);
			this.Controls.Add(this.customerBudgetLabel);
			this.Controls.Add(this.customerBudgetTextBox);
			this.Controls.Add(this.customerTypeLabel);
			this.Controls.Add(this.customerTypeComboBox);
			this.Controls.Add(this.BtnMusteriEkle);
			this.Name = "Frm_M_ekle";
			this.Text = "Frm_M_ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label customerNameLabel;
		private System.Windows.Forms.TextBox customerNameTextBox;
		private System.Windows.Forms.Label customerBudgetLabel;
		private System.Windows.Forms.TextBox customerBudgetTextBox;
		private System.Windows.Forms.Label customerTypeLabel;
		private System.Windows.Forms.ComboBox customerTypeComboBox;
		private System.Windows.Forms.Button BtnMusteriEkle;
	}
}