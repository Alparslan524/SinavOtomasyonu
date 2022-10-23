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
    
    public partial class frmSifremiUnuttum : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");

        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnYeniSifreGir_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdiSifremiUnuttum.Text=="")
            {
                MessageBox.Show("Kullanıcı Adınızı Giriniz");
                
            }
            else
            {
                 lblYeniSifre.Visible = true;
            txtYeniSifre.Visible = true;
            btnSifreyiKaydet.Visible = true;
            }



        }
        int temp = 0;
        private void btnSifreyiKaydet_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("update Tbl_Kullanici Set Sifre=@yenisifre where KullaniciAdi=@kullaniciadi", baglanti);
            //komut.Parameters.AddWithValue("@yenisifre", txtYeniSifre.Text);
            //komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdiSifremiUnuttum.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Kullanici",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                if (txtKullaniciAdiSifremiUnuttum.Text == oku["KullaniciAdi"].ToString())
                {

                    SqlConnection baglanti1 = new SqlConnection(@"Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
                    SqlCommand komut1 = new SqlCommand("update Tbl_Kullanici Set Sifre=@pYenisifre where KullaniciAdi=@pKullaniciadi",baglanti1);
                    baglanti1.Open();
                    komut1.Parameters.AddWithValue("@pYeniSifre", txtYeniSifre.Text);
                    komut1.Parameters.AddWithValue("@pKullaniciadi", txtKullaniciAdiSifremiUnuttum.Text);
                    komut1.ExecuteNonQuery();
                    baglanti1.Close();
                    temp=1;
                    break;
                }
                temp = 0;
            }
            baglanti.Close();
            

            if (temp==1)
            {
                MessageBox.Show("Şifreniz Değiştirilmiştir");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Bulunamadı");
            }



        }
    }
}
