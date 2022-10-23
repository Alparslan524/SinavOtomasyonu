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
    public partial class frmOgrenciEkran : Form
    {
        public frmOgrenciEkran()
        {
            InitializeComponent();
        }

        private void btnSınavModulGetir_Click(object sender, EventArgs e)
        {
            frmSinavModul frmsinavmodul = new frmSinavModul();
            frmsinavmodul.lblKullaniciad.Text = lblOgrenciEkranKulalniciAd.Text;
            this.Hide();
            frmsinavmodul.ShowDialog();
            
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 frmanamenu = new Form1();
            frmanamenu.Show();
            this.Hide();
        }

        private void btnAlistirmaGetir_Click(object sender, EventArgs e)
        {
            frmAlistirmaModul frmalistirmamodul = new frmAlistirmaModul();
            frmalistirmamodul.Show();
            this.Hide();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRapor frmrapor = new frmRapor();
            frmrapor.lblKullaniciAdiRapor.Text = lblOgrenciEkranKulalniciAd.Text;
            this.Hide();
            frmrapor.ShowDialog();
            
        }
    }
}
