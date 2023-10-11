using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string intput = Console.ReadLine();

            using (var connection = new SqlConnection(""))
            {
                string sql = "SELECT UserId, Username, FullName FROM Users WHERE Username= '" 
                    + intput + "' Order by Fullname";

                var adapter = new SqlDataAdapter(sql, connection);
                var result = new DataSet();
                adapter.Fill(result);
            }


        }
    }
}