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
    public partial class frmYeniKayit : Form
    {
        public frmYeniKayit()
        {
            InitializeComponent();
        }
        
        public void Temizle()
        {
            txtYKEmail.Text = "";
            txtYKIsim.Text = "";
            txtYKKullaniciadi.Text = "";
            txtYKSifre.Text = "";
            txtYKSifre2.Text = "";
            txtYKSoyisim.Text = "";
            cmboxKullaniciTipi.Text = "";
        }

        private void btnYeniKayitOlustur_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            KisiVeriTabani kayit = new KisiVeriTabani();




            if (txtYKSifre.Text == txtYKSifre2.Text)
            {

                kisi.Sifre = txtYKSifre.Text;
                kisi.Sifre2= txtYKSifre2.Text;
                kisi.Ad = txtYKIsim.Text;
                kisi.Soyad = txtYKSoyisim.Text;
                kisi.Email = txtYKEmail.Text;
                kisi.KullaniciAdi = txtYKKullaniciadi.Text;

                if (cmboxKullaniciTipi.Text == "Admin")
                    kisi.KullaniciTipi = 1;
                else 
                    if (cmboxKullaniciTipi.Text == "Sınav Sorumlusu")
                    kisi.KullaniciTipi = 2;
                else
                    kisi.KullaniciTipi = 3;
               
                MessageBox.Show("Kayıt tamamlandı...");
            }
            else
            {

                txtYKSifre.Text = "";
                txtYKSifre2.Text = "";

            }

            Temizle();
            kayit.Kayit(kisi);

        
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 frmanamenu = new Form1();
            frmanamenu.Show();
            this.Hide();
        }
    }
}
