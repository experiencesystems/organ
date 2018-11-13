using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public static class StringConexao
    {
        private static string _connectionString = @"Data Source=LAB2PC12\SA;Initial Catalog=dbOrgan;Persist Security Info=True;User ID=sa;Password=1234567";
        public static string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
    }
}
