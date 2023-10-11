using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string sql = "SELECT * FROM Users WHERE Id = " + args[0];

            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.ExecuteNonQuery();
        }
    }
}