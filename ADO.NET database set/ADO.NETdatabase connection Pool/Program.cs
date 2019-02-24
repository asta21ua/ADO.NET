using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace ADO.NETdatabase_connection_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog=usersdb; Integrated Security = True;";

            for (int i = 0; i < 1000; i++)
            {
                SqlConnection connection1 = new SqlConnection(connectionString);

                connection1.Open();

                Thread.Sleep(100);
                Console.WriteLine("connection opened  " + i);

                connection1.Close();
            }


            Console.WriteLine();

        }
    }
}
