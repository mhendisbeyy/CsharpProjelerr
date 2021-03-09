using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Deneme
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ALI;Initial Catalog=Deneme1;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
