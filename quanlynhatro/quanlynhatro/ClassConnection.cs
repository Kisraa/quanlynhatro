using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhatro
{
    public class ClassConnection
    {
        private static String connectionString = @"Data Source=LAPTOP-45OEL6IM\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security=True";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }
    }
}
