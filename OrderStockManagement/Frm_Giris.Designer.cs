namespace OrderStockManagement
{
	partial class Frm_Giris
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
			this.Btn_Admin = new System.Windows.Forms.Button();
			this.Btn_musteri = new System.Windows.Forms.Button();
			this.orderCustomerIdLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Admin
			// 
			this.Btn_Admin.Location = new System.Drawing.Point(70, 120);
			this.Btn_Admin.Name = "Btn_Admin";
			this.Btn_Admin.Size = new System.Drawing.Size(211, 152);
			this.Btn_Admin.TabIndex = 0;
			this.Btn_Admin.Text = "ADMİN GİRİŞİ";
			this.Btn_Admin.UseVisualStyleBackColor = true;
			this.Btn_Admin.Click += new System.EventHandler(this.Btn_Admin_Click);
			// 
			// Btn_musteri
			// 
			this.Btn_musteri.Location = new System.Drawing.Point(332, 120);
			this.Btn_musteri.Name = "Btn_musteri";
			this.Btn_musteri.Size = new System.Drawing.Size(211, 152);
			this.Btn_musteri.TabIndex = 1;
			this.Btn_musteri.Text = "MÜŞTERİ GİRİŞİ";
			this.Btn_musteri.UseVisualStyleBackColor = true;
			this.Btn_musteri.Click += new System.EventHandler(this.Btn_musteri_Click);
			// 
			// orderCustomerIdLabel
			// 
			this.orderCustomerIdLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderCustomerIdLabel.ForeColor = System.Drawing.Color.Maroon;
			this.orderCustomerIdLabel.Location = new System.Drawing.Point(117, 46);
			this.orderCustomerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.orderCustomerIdLabel.Name = "orderCustomerIdLabel";
			this.orderCustomerIdLabel.Size = new System.Drawing.Size(380, 46);
			this.orderCustomerIdLabel.TabIndex = 26;
			this.orderCustomerIdLabel.Text = "Eş Zamanlı Ürün Stok Yönetimi";
			// 
			// Frm_Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 359);
			this.Controls.Add(this.orderCustomerIdLabel);
			this.Controls.Add(this.Btn_musteri);
			this.Controls.Add(this.Btn_Admin);
			this.Name = "Frm_Giris";
			this.Text = "Frm_Giris";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Btn_Admin;
		private System.Windows.Forms.Button Btn_musteri;
		private System.Windows.Forms.Label orderCustomerIdLabel;
	}
}