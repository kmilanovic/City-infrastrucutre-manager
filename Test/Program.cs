using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection connection = new DBConnection();
            connection.ReadDBData();
            Console.ReadLine();
        }
    }
}
