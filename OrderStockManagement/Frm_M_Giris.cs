using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OrderStockManagement.Models;

namespace OrderStockManagement
{
	public partial class Frm_M_Giris : Form
	{
		public Frm_M_Giris()
		{
			InitializeComponent();
		}

		private void Btn_M_Giris_Click(object sender, EventArgs e)
		{
			string query = "SELECT * FROM customers WHERE CustomerID = @id AND Password = @Sifre";

			MySqlParameter[] parameters = {
			new MySqlParameter("@id", Msk_M_Id.Text),
			new MySqlParameter("@Sifre", Txt_M_Sifre.Text)
		};

			try
			{
				DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

				if (result.Rows.Count > 0)
				{
					
					Frm_Musteri fr = new Frm_Musteri();
					fr.M_id = Msk_M_Id.Text;
					fr.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Hatalı ID veya Şifre. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Frm_M_Giris_FormClosing(object sender, FormClosingEventArgs e)
		{
			Frm_Giris fr = new Frm_Giris();
			fr.Show();
			this.Hide();
		}
	}
}
