namespace OrderStockManagement
{
	partial class Frm_M_Giris
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
			this.Btn_M_Giris = new System.Windows.Forms.Button();
			this.Msk_M_Id = new System.Windows.Forms.TextBox();
			this.Txt_M_Sifre = new System.Windows.Forms.TextBox();
			this.Musteri = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_M_Giris
			// 
			this.Btn_M_Giris.Location = new System.Drawing.Point(107, 167);
			this.Btn_M_Giris.Name = "Btn_M_Giris";
			this.Btn_M_Giris.Size = new System.Drawing.Size(185, 43);
			this.Btn_M_Giris.TabIndex = 0;
			this.Btn_M_Giris.Text = "Giriş Yap";
			this.Btn_M_Giris.UseVisualStyleBackColor = true;
			this.Btn_M_Giris.Click += new System.EventHandler(this.Btn_M_Giris_Click);
			// 
			// Msk_M_Id
			// 
			this.Msk_M_Id.Location = new System.Drawing.Point(189, 79);
			this.Msk_M_Id.Name = "Msk_M_Id";
			this.Msk_M_Id.Size = new System.Drawing.Size(100, 22);
			this.Msk_M_Id.TabIndex = 1;
			// 
			// Txt_M_Sifre
			// 
			this.Txt_M_Sifre.Location = new System.Drawing.Point(189, 128);
			this.Txt_M_Sifre.Name = "Txt_M_Sifre";
			this.Txt_M_Sifre.Size = new System.Drawing.Size(100, 22);
			this.Txt_M_Sifre.TabIndex = 2;
			this.Txt_M_Sifre.UseSystemPasswordChar = true;
			// 
			// Musteri
			// 
			this.Musteri.AutoSize = true;
			this.Musteri.Location = new System.Drawing.Point(104, 82);
			this.Musteri.Name = "Musteri";
			this.Musteri.Size = new System.Drawing.Size(69, 16);
			this.Musteri.TabIndex = 3;
			this.Musteri.Text = "Müşteri ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(134, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Sifre";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Frm_M_Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 321);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Musteri);
			this.Controls.Add(this.Txt_M_Sifre);
			this.Controls.Add(this.Msk_M_Id);
			this.Controls.Add(this.Btn_M_Giris);
			this.Name = "Frm_M_Giris";
			this.Text = "Frm_M_Giris";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_M_Giris_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_M_Giris;
		private System.Windows.Forms.TextBox Msk_M_Id;
		private System.Windows.Forms.TextBox Txt_M_Sifre;
		private System.Windows.Forms.Label Musteri;
		private System.Windows.Forms.Label label2;
	}
}