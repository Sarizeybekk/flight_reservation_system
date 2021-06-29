using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    class sqlbaglantisi1
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - 70UES6S; Initial Catalog = Uyeler; Integrated Security = True");
            baglanti.Open();
            return baglanti;
        }
        
    }
}
