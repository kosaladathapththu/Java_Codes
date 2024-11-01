using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace database
{
    public class ConnectionManager
    {
        public static SqlConnection newcon;
        public static string constr = ConnectionManager.ConnectionStrings["connstring"].ConnectionString;
     
    }
}
