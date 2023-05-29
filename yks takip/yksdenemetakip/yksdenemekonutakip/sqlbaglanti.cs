using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace yksdenemekonutakip
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-FMJQ9I6Q\\SQLEXPRESS;Initial Catalog=ykstakip;Integrated Security=True");

            baglan.Open();
            return baglan;

        }
    }
}
