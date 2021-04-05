using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * from TblDers", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DersID"].ToString());
                ent.Dersad = dr["DersAd"].ToString();
                ent.Min = int.Parse(dr["DersMinKont"].ToString());
                ent.Max = int.Parse(dr["DersMaksKont"].ToString());
                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TblBasvuruForm (OgrID,DersID) " +
             "values (@P1,@P2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", parametre.Basogrid);
            komut.Parameters.AddWithValue("@P2", parametre.Basdersid);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
