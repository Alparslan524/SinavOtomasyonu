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
    public partial class frmSinavSorumlusu : Form
    {
        public frmSinavSorumlusu()
        {
            InitializeComponent();
        }

        private void btnGirisSS_Click(object sender, EventArgs e)
        {
            bool giris_yapildimi;
            Kisi kisi = new Kisi();
            KisiVeriTabani kisiveritabani = new KisiVeriTabani(); // yapıcı method ile bağlan() methodu çalışır...

            kisi.KullaniciAdi = txtKullaniciAdiSS.Text;
            kisi.Sifre = txtSifreSS.Text;
            kisi.KullaniciTipi = 2; 

            giris_yapildimi = kisiveritabani.Giris(kisi);

            if (giris_yapildimi)
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız");
                frmSoruEklemeModulu frmsorueklememodulu = new frmSoruEklemeModulu();
                frmsorueklememodulu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void btnSifremiUnuttumSS_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum frmsifremiunuttum = new frmSifremiUnuttum();
            frmsifremiunuttum.Show();
            this.Hide();
        }
    }
}
