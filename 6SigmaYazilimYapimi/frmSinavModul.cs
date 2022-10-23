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
    

    public partial class frmSinavModul : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
        
        public frmSinavModul()
        {
            InitializeComponent();
        }
        private void RadyoButonCheckedFalse()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }


        private void Sonucu_Veritabanina_Ekle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_Sonuc (KullaniciAdi,DogruSayisi,YanlisSayisi,SinavTarihi) values (@kullaniciadi,@dogrusayi,@yanlissayi,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@kullaniciadi", lblKullaniciad.Text);
            komut.Parameters.AddWithValue("@dogrusayi", dogru_sayisi);
            komut.Parameters.AddWithValue("@yanlissayi", (yapilan_soru - dogru_sayisi));
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Doğru Sayisi: " + dogru_sayisi + "\n" +"Yanlış Sayısı: " + (yapilan_soru - dogru_sayisi));
            frmOgrenciEkran frmogrenciekran = new frmOgrenciEkran();
            frmogrenciekran.Show();
            this.Hide();
        }



        private void frmSinavModul_Load(object sender, EventArgs e)
        {

        }
        
        int dogru_sayisi  = 0;
        int yapilan_soru = 0;
        string dogru_secenek;
        string resim_yol;
        int saniye = 60;
        int dakika = 9;

        private void btnSinavBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            RadyoButonCheckedFalse();
            btnSonrakiSoru.Enabled = false;
            btnSoruKaydet.Enabled = true;
            btnSonrakiSoru.Text = "Sonraki Soru";
          

            if (yapilan_soru == 10)
            {
                MessageBox.Show("Sınavınız Bitti");
                Sonucu_Veritabanina_Ekle();
                
            }

            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select S.SoruResimYolu,S.Dogru,K.KonuAdi,U.UniteAdi from tbl_Sorular S inner join tbl_Konu K on S.KonuID=K.KonuID inner join tbl_unite U on S.UniteID = U.UniteID order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    resim_yol = (oku["SoruResimYolu"].ToString());
                    dogru_secenek = (oku["Dogru"].ToString());
                    pictureBoxSinavModul.ImageLocation = resim_yol;
                    lblUnite.Text = (oku["UniteAdi"].ToString());
                    lblKonu.Text = (oku["KonuAdi"].ToString());
                }
                
            }

            baglanti.Close();
            
        }

        private void btnSoruKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSoruKaydet_Click_1(object sender, EventArgs e)
        {
            yapilan_soru = yapilan_soru + 1;
            if ((radioButtonA.Checked == true) && (radioButtonA.Text == dogru_secenek))
            {
                dogru_sayisi = dogru_sayisi + 1;
            }
            else if ((radioButtonB.Checked == true) && (radioButtonB.Text == dogru_secenek))
            {
                dogru_sayisi = dogru_sayisi + 1;
            }
            else if ((radioButtonC.Checked == true) && (radioButtonC.Text == dogru_secenek))
            {
                dogru_sayisi = dogru_sayisi + 1;
            }
            else if ((radioButtonD.Checked == true) && (radioButtonD.Text == dogru_secenek))
            {
                dogru_sayisi = dogru_sayisi + 1;
            }
            btnSoruKaydet.Enabled = false;
            btnSonrakiSoru.Enabled = true;
             
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye - 1;
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            if (saniye==0)
            {
                dakika = dakika - 1;
                lblDakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (lblDakika.Text == "0" && lblSaniye.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("Süreniz Bitti");
                Sonucu_Veritabanina_Ekle();
            }
        }
    }
    
}