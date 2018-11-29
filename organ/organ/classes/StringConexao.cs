using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public static class StringConexao
    {
        private static string _connectionString = @"Data Source=SANTANA-COMPUTE\SQLEXPRESS;Initial Catalog=dbOrgan;Integrated Security=True";
        //private static string _connectionString = @"Data Source=SANTANA-COMPUTE\SQLEXPRESS;Initial Catalog=dbOrgan;Integrated Security=True";
        //private static string _connectionString = @"Data Source=SANTANA-COMPUTE\SQLEXPRESS;Initial Catalog=dbOrgan;Integrated Security=True";
        public static string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
    }
}
