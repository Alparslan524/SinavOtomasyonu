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
    public partial class frmAdminSoruSil : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter veri_adapter;
        DataSet veri_set;
        SqlCommand komut;

        void SoruListele()//DataGridviewe Soruları Listeleyecek
        {
            baglanti = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
            veri_adapter = new SqlDataAdapter("Select * From tbl_Sorular", baglanti);
            veri_set = new DataSet();
            baglanti.Open();
            veri_adapter.Fill(veri_set, "tbl_Sorular");
            dataGridViewSoruSil.DataSource = veri_set.Tables["tbl_Sorular"];
            baglanti.Close();
       }
        void SoruSil(int sayi)
        {
            baglanti.Open();
            string sql_komutu = "DELETE FROM tbl_Sorular WHERE SoruID=@sayi";
            komut = new SqlCommand(sql_komutu, baglanti);
            komut.Parameters.AddWithValue("@sayi", sayi);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        public frmAdminSoruSil()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmAdminEkrani frmadminekrani = new frmAdminEkrani();
            frmadminekrani.Show();
            this.Hide();
        }

        private void btnSoruSil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in dataGridViewSoruSil.SelectedRows)  //sadece seçili satırları silme
            {
                int sayi = Convert.ToInt32(drow.Cells[0].Value);
                SoruSil(sayi);
            }
            
        }
        private void frmAdminSoruSil_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKullaniciListle_Click(object sender, EventArgs e)
        {
            SoruListele();
        }
    }
}
