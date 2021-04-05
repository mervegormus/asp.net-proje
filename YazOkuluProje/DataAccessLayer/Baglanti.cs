using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=hybridcryptographyserver.database.windows.net;Initial Catalog=DbYazOkulu;Persist Security Info=True;User ID=auth_admin;Password=Merve1234");
    }
}
