using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OtomasyonKutuphane
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-BB7DPE12\SQLEXPRESS;Initial Catalog=KUTUPHANE;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
