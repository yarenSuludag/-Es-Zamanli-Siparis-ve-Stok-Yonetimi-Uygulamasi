using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderStockManagement
{
	public partial class Frm_Giris : Form
	{
		public Frm_Giris()
		{
			InitializeComponent();
		}

		private void Btn_Admin_Click(object sender, EventArgs e)
		{
			Form1 fr = new Form1();
			fr.Show();
			this.Hide();
		}

		private void Btn_musteri_Click(object sender, EventArgs e)
		{
			Frm_M_Giris fr = new Frm_M_Giris();
			fr.Show();
			this.Hide();
		}

        private void orderCustomerIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Frm_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
