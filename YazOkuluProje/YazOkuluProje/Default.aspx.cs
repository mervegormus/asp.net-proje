using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;



namespace YazOkuluProje
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TextAd.Text;
            ent.Soyad = TextSoyad.Text;
            ent.Numara = TextNumara.Text;
            ent.Sifre = TextSifre.Text;
            ent.Mail = TextMail.Text;
            ent.Fotograf = TextFoto.Text;

            BLLOgrenci.OgrenciEkleBLL(ent);
        }
    }
}