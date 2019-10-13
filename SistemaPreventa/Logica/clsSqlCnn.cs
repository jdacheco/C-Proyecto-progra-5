using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Logica
{
    public class clsSqlCnn
    {
        SqlConnection cn;

        public clsSqlCnn(string ConectionString)
        {
            cn = new SqlConnection(ConectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
