using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;




namespace ADO.NET_database_connection_Try_chatch
{
    class Program
    {
        // linking the created MY SQL data base named "usersdb" in C# 
        // creating configurations in app.config
        // The main syntax of connection string is following: string nameofit = @"Data Source = add Source; Initial Catalog = the name of DataBase; Integrated Security = usually equals True";
        // The other option can be added like Username, Password, Packet Size, AttachDBFileName et.

        static void Main(string[] args)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string connectionString = @"Data Source= .\SQLEXPRESS; Initial Catalog = usersdb; Integrated Security = True";

            // creating the connection
            SqlConnection connection = new SqlConnection(connectionString);

            // opening connection 

            try
            {
                connection.Open();

                Console.WriteLine("The connecton is open");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            // closeing the connection

            {
                connection.Close();
                Console.WriteLine("The connection is closed");

            }

            Console.ReadLine();
        }
    }
}
