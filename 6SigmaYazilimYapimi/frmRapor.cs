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
    public partial class frmRapor : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
        SqlDataReader oku;
        public frmRapor()
        {
            InitializeComponent();
        }

        private void btnAnaMenuRapor_Click(object sender, EventArgs e)
        {
            frmOgrenciEkran frmogrenciekran = new frmOgrenciEkran();
            frmogrenciekran.Show();
            this.Hide();
        }

        private void btnGirisRapor_Click(object sender, EventArgs e)
        {
            listViewRapor.Visible = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KullaniciAdi,DogruSayisi,YanlisSayisi,SinavTarihi from Table_Sonuc where KullaniciAdi=@kullaniciadi",baglanti);
            komut.Parameters.AddWithValue("@kullaniciadi",lblKullaniciAdiRapor.Text);
            komut.ExecuteNonQuery();
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem oge = new ListViewItem(oku["KullaniciAdi"].ToString());
                 oge.SubItems.Add(oku["DogruSayisi"].ToString());
                 oge.SubItems.Add(oku["YanlisSayisi"].ToString());
                 oge.SubItems.Add(oku["SinavTarihi"].ToString());
                 listViewRapor.Items.Add(oge);

            }

            baglanti.Close();
        }
    }
}
