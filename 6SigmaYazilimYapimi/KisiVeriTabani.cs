using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _6SigmaYazilimYapimi
{
    public class KisiVeriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public KisiVeriTabani()
        {
            Baglan();
        }

        public void Baglan()
        {

            baglanti = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=YazilimYapimi;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        public void Kayit(Kisi k)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = "insert into Tbl_Kullanici (KullaniciAdi,Ad,Soyad,Sifre,Email,KullaniciTipiID) values (@pKullaniciAdi,@pAd,@pSoyad,@pSifre,@pEmail,@pKullaniciTipiId)";
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pKullaniciAdi", k.KullaniciAdi);
                komut.Parameters.AddWithValue("@pAd", k.Ad);
                komut.Parameters.AddWithValue("@pSoyad", k.Soyad);
                komut.Parameters.AddWithValue("@pSifre", k.Sifre);
                komut.Parameters.AddWithValue("@pEmail", k.Email);
                komut.Parameters.AddWithValue("@pKullaniciTipiId", k.KullaniciTipi);
                komut.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }


        public bool Giris(Kisi k)
        {

            try
            {
                baglanti.Open();
                komut.CommandText = "select * from Tbl_Kullanici where KullaniciTipiID = @kKullaniciTipiId";
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@kKullaniciTipiId", k.KullaniciTipi);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    if (k.KullaniciAdi == reader["KullaniciAdi"].ToString() && k.Sifre == reader["Sifre"].ToString())
                    {
                        return true;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
            return false;

        }

    }
}

