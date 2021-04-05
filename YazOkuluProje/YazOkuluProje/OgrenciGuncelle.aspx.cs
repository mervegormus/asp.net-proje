using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace YazOkuluProje
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrID"].ToString());
            TextId.Text = x.ToString();
            TextId.Enabled = false;
            //EntityOgrenci ent = new EntityOgrenci();
            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
                TextAd.Text = OgrList[0].Ad.ToString();
                TextSoyad.Text = OgrList[0].Soyad.ToString();
                TextNumara.Text = OgrList[0].Numara.ToString();
                TextMail.Text = OgrList[0].Mail.ToString();
                TextSifre.Text = OgrList[0].Sifre.ToString();
                TextFoto.Text = OgrList[0].Fotograf.ToString();
            }
        }

        protected void TextAd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TextAd.Text;
            ent.Soyad = TextSoyad.Text;
            ent.Numara = TextNumara.Text;
            ent.Mail = TextMail.Text;
            ent.Sifre = TextSifre.Text;
            ent.Fotograf = TextFoto.Text;
            ent.Id = Convert.ToInt32(TextId.Text);
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}