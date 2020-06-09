using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DBConnection
    {
        private SqlConnection _connection = new SqlConnection("Server=193.198.57.183; Database=PIS_TEST;User Id=student;Password=student");

        public void ReadDBData()
        {
            try
            {
                var command = new SqlCommand("SELECT korisnicko_ime, lozinka FROM [03_Korisnik]", _connection);
                _connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    }
                }
                _connection.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

    }
}
