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
    public partial class frmAlistirmaModul : Form
    {
        private void RadyoButonCheckedFalse()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }



        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
        int dogru_sayisi = 0;
        int yapılan_soru=0;
        string dogru_secenek;
        string resim_yol;
       
        public frmAlistirmaModul()
        {
            InitializeComponent();
        }
        

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            RadyoButonCheckedFalse();
            
            btnSonrakiSoru.Enabled = false;
            btnSoruKaydet.Enabled = true;
            lblDogruSecenek.Visible = false;
            btnSonrakiSoru.Text = "Sonraki Soru";

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
            baglanti.Close();
        }

        private void btnSinavBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alıştırma Bitti" + "\n" + "Doğru Sayisi: " + dogru_sayisi + " \n" + "Yanlış Sayısı: " +(yapılan_soru-dogru_sayisi));
            frmOgrenciEkran frmogrenciekran = new frmOgrenciEkran();
            frmogrenciekran.Show();
            this.Hide();
        }

        private void btnSoruKaydet_Click(object sender, EventArgs e)
        {
            yapılan_soru = yapılan_soru + 1;
            lblDogruSecenek.Text = dogru_secenek;
            lblDogruSecenek.Visible = true;
            
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
            lblDoğruSayisi.Text = dogru_sayisi.ToString();
            lblYanlisSayisi.Text = (yapılan_soru - dogru_sayisi).ToString();

        }
    }
}
