using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NET_database_connection_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectWithDB().GetAwaiter();
        }

        private static async Task ConnectWithDB()
        {
            string connectionString = @"Data Source = .\SQLEXPRESS; Initial Cataloge = userdb; Integrated Source= True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                Console.WriteLine("Connection is open");
                
            }

            Console.WriteLine("Connection is closed");
            Console.ReadKey();
        }









    }



}
