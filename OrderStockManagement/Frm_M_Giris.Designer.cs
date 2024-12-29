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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M_Giris));
            this.Btn_M_Giris = new System.Windows.Forms.Button();
            this.Msk_M_Id = new System.Windows.Forms.TextBox();
            this.Txt_M_Sifre = new System.Windows.Forms.TextBox();
            this.Musteri = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_M_Giris
            // 
            this.Btn_M_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_M_Giris.Location = new System.Drawing.Point(444, 272);
            this.Btn_M_Giris.Name = "Btn_M_Giris";
            this.Btn_M_Giris.Size = new System.Drawing.Size(81, 40);
            this.Btn_M_Giris.TabIndex = 0;
            this.Btn_M_Giris.Text = "Giriş Yap";
            this.Btn_M_Giris.UseVisualStyleBackColor = true;
            this.Btn_M_Giris.Click += new System.EventHandler(this.Btn_M_Giris_Click);
            // 
            // Msk_M_Id
            // 
            this.Msk_M_Id.Location = new System.Drawing.Point(221, 119);
            this.Msk_M_Id.Name = "Msk_M_Id";
            this.Msk_M_Id.Size = new System.Drawing.Size(187, 22);
            this.Msk_M_Id.TabIndex = 1;
            // 
            // Txt_M_Sifre
            // 
            this.Txt_M_Sifre.Location = new System.Drawing.Point(221, 215);
            this.Txt_M_Sifre.Name = "Txt_M_Sifre";
            this.Txt_M_Sifre.Size = new System.Drawing.Size(187, 22);
            this.Txt_M_Sifre.TabIndex = 2;
            this.Txt_M_Sifre.UseSystemPasswordChar = true;
            // 
            // Musteri
            // 
            this.Musteri.AutoSize = true;
            this.Musteri.BackColor = System.Drawing.Color.Transparent;
            this.Musteri.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Musteri.Location = new System.Drawing.Point(38, 119);
            this.Musteri.Name = "Musteri";
            this.Musteri.Size = new System.Drawing.Size(125, 23);
            this.Musteri.TabIndex = 3;
            this.Musteri.Text = "Müsteri ID:";
            this.Musteri.Click += new System.EventHandler(this.Musteri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifre:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frm_M_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Musteri);
            this.Controls.Add(this.Txt_M_Sifre);
            this.Controls.Add(this.Msk_M_Id);
            this.Controls.Add(this.Btn_M_Giris);
            this.Name = "Frm_M_Giris";
            this.Text = "Frm_M_Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_M_Giris_FormClosing);
            this.Load += new System.EventHandler(this.Frm_M_Giris_Load);
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