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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnGirisA_Click(object sender, EventArgs e)
        {
            {
                bool giris_yapildimi;
                Kisi kisi = new Kisi();
                KisiVeriTabani kisiveritabani = new KisiVeriTabani(); // yapıcı method ile bağlan() methodu çalışır...

                kisi.KullaniciAdi = txtKullaniciAdiA.Text;
                kisi.Sifre = txtSifreA.Text;
                kisi.KullaniciTipi = 1; 

                giris_yapildimi = kisiveritabani.Giris(kisi);

                if (giris_yapildimi)
                {
                    MessageBox.Show("Başarıyla Giriş Yaptınız");
                    frmAdminEkrani frmadminekrani = new frmAdminEkrani();
                    frmadminekrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }

            }
        }

        private void btnSifremiUnuttumAdmin_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum frmsifremiunuttum = new frmSifremiUnuttum();
            frmsifremiunuttum.Show();
            this.Hide();
        }
    }
}
