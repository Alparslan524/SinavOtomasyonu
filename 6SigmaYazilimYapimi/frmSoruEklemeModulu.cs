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
    public partial class frmSoruEklemeModulu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
        public frmSoruEklemeModulu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_Sorular (UniteID,KonuID,Dogru,SoruResimYolu) values (@uniteID,@konuID,@dogru,@resimyol)",baglanti);
            komut.Parameters.AddWithValue("@uniteID",comboBoxUnite.SelectedIndex+1);
            komut.Parameters.AddWithValue("@konuID",comboBoxKonu.SelectedIndex+1);
            komut.Parameters.AddWithValue("@dogru", comboBoxDogruSik.Text);
            komut.Parameters.AddWithValue("@resimyol", txtResimYol.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sorunuz Eklendi");
        }

        private void btnResimYolu_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxSoruEkleme.ImageLocation = openFileDialog1.FileName;
            txtResimYol.Text = openFileDialog1.FileName;
        }

        private void frmSoruEklemeModulu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazilimYapimiDataSet1.VievSorular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.vievSorularTableAdapter.Fill(this.yazilimYapimiDataSet1.VievSorular);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yazilimYapimiDataSet1.VievSorular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.vievSorularTableAdapter.Fill(this.yazilimYapimiDataSet1.VievSorular);
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 frmanamenu = new Form1();
            frmanamenu.Show();
            this.Hide();
        }

        private void txtResimYol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
