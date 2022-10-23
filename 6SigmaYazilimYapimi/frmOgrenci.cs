using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _6SigmaYazilimYapimi
{
    public partial class frmOgrenci : Form
    {
        
        public frmOgrenci()
        {
            InitializeComponent();
        }

        private void btnGirisO_Click(object sender, EventArgs e)
        {
            
            
            bool giris_yapildimi;
            Kisi kisi = new Kisi();
            KisiVeriTabani kisiveritabani = new KisiVeriTabani();

            kisi.KullaniciAdi = txtKullaniciAdiO.Text;
            kisi.Sifre = txtSifreO.Text;
            kisi.KullaniciTipi = 3;

           

        giris_yapildimi = kisiveritabani.Giris(kisi);

            if (giris_yapildimi)
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız");
                frmOgrenciEkran frmogrenciekran = new frmOgrenciEkran();
                frmogrenciekran.lblOgrenciEkranKulalniciAd.Text = txtKullaniciAdiO.Text;
                this.Hide();
                frmogrenciekran.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }

        private void btnSifremiUnuttumOgrenci_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum frmsifremiunuttum = new frmSifremiUnuttum();
            frmsifremiunuttum.Show();
            this.Hide();
        }
    }
}
