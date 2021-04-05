using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TblOgr(OgrAd,OgrSoyad,OgrNumara,OgrMail,OgrSifre,OgrFoto)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre.Ad);
            komut.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut.Parameters.AddWithValue("@p3", parametre.Numara);
            komut.Parameters.AddWithValue("@p4", parametre.Mail);
            komut.Parameters.AddWithValue("@p5", parametre.Sifre);
            komut.Parameters.AddWithValue("@p6", parametre.Fotograf);
            return komut.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut1 = new SqlCommand("Select * from TblOgr", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OgrID"].ToString());
                ent.Ad = dr["OgrAd"].ToString();
                ent.Soyad = dr["OgrSoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Mail = dr["OgrMail"].ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OgrBakiye"].ToString());
                ent.Fotograf = dr["OgrFoto"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut2 = new SqlCommand("Delete From TblOgr Where OgrID=@P1", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", parametre);
            return komut2.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut3 = new SqlCommand("Select * from TblOgr Where OgrID=@P1", Baglanti.bgl);
            komut3.Parameters.AddWithValue("@P1", id);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                
                ent.Ad = dr["OgrAd"].ToString();
                ent.Soyad = dr["OgrSoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Mail = dr["OgrMail"].ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OgrBakiye"].ToString());
                ent.Fotograf = dr["OgrFoto"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut4 = new SqlCommand("Update TblOgr Set OgrAd=@P1, OgrSoyad=@P2,OgrNumara=@P3,OgrMail=@P4," +
                "OgrSifre=@P5,OgrFoto=@P6 Where OgrID=@P7", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", deger.Ad);
            komut4.Parameters.AddWithValue("@P2", deger.Soyad);
            komut4.Parameters.AddWithValue("@P3", deger.Numara);
            komut4.Parameters.AddWithValue("@P4", deger.Mail);
            komut4.Parameters.AddWithValue("@P5", deger.Sifre);
            komut4.Parameters.AddWithValue("@P6", deger.Fotograf);
            komut4.Parameters.AddWithValue("@P7", deger.Id);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
