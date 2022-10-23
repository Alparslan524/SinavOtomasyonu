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
    public partial class frmAdminEkrani : Form
    {
        public frmAdminEkrani()
        {
            InitializeComponent();
        }

        private void btnAdminSoruSil_Click(object sender, EventArgs e)
        {
            frmAdminSoruSil frmAdminsorusil = new frmAdminSoruSil();
            frmAdminsorusil.Show();
            this.Hide();
        }

        private void btnAdminKullaniciSil_Click(object sender, EventArgs e)
        {
            frmAdminKullaniciSil frmadminkullanicisil = new frmAdminKullaniciSil();
            frmadminkullanicisil.Show();
            this.Hide();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 frmanamenu = new Form1();
            frmanamenu.Show();
            this.Hide();
        }
    }
}
