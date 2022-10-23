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
    public partial class frmAdminKullaniciSil : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter veri_adapter;
        DataSet veri_set;
        SqlCommand komut;

        void KullaniciListele()//DataGridviewe Soruları Listeleyecek
        {
            baglanti = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
            veri_adapter = new SqlDataAdapter("Select * From Tbl_Kullanici", baglanti);
            veri_set = new DataSet();
            baglanti.Open();
            veri_adapter.Fill(veri_set, "Tbl_Kullanici");
            dataGridViewKullaniciSil.DataSource = veri_set.Tables["Tbl_Kullanici"];
            baglanti.Close();
        }

        void KullaniciSil(int sayi)
        {
            baglanti.Open();
            string sql_komutu = "DELETE FROM Tbl_Kullanici WHERE KullaniciID=@sayi";
            komut = new SqlCommand(sql_komutu, baglanti);
            komut.Parameters.AddWithValue("@sayi", sayi);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public frmAdminKullaniciSil()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmAdminEkrani frmadminekrani = new frmAdminEkrani();
            frmadminekrani.Show();
            this.Hide();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridViewKullaniciSil.SelectedRows)  //sadece seçili satırları silme
            {
                int sayi = Convert.ToInt32(drow.Cells[0].Value);
                KullaniciSil(sayi);
            }
        }

        private void frmAdminKullaniciSil_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKullaniciListle_Click(object sender, EventArgs e)
        {
            KullaniciListele();
        }
    }
}
