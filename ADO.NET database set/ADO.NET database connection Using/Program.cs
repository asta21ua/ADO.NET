using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ADO.NET_database_connection_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            // connecting local DataBase with USING to close Automatically 

            string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = userdb; Integrated Source= True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine("Connecton is Open");
            }
            Console.WriteLine("Connection is Closed");

            Console.ReadLine();
        }

    }
}
