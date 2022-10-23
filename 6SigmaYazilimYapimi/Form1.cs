using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6SigmaYazilimYapimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmadmin = new frmAdmin();
            frmadmin.Show();
            this.Hide();
        }

        private void btnSinavSorumlusu_Click(object sender, EventArgs e)
        {
            frmSinavSorumlusu frmsinavsorumlusu = new frmSinavSorumlusu();
            frmsinavsorumlusu.Show();
            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenci frmogrenci = new frmOgrenci();
            frmogrenci.Show();
            this.Hide();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayit frmyenikayit = new frmYeniKayit();
            frmyenikayit.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
