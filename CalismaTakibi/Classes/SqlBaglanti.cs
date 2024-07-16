using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CalismaTakibi.Classes
{
    public class SqlBaglanti
    {
        public static SqlConnection connection = new SqlConnection("Data Source=YSF\\SQLEXPRESS;Initial Catalog=Calismalar;Integrated Security=True");

        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();
            }
        }
    }
}
