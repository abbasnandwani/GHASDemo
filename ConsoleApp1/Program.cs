using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string intput = Console.ReadLine();

            TestClass tc=new TestClass();

            var res = tc.GetUsers(intput);


            String numberList = "";
            for (int i = 0; i <= 100; i++)
            {
                numberList += i + " ";
            }
            Console.WriteLine(numberList);

        }
    }

    public class TestClass
    {
        string connstr = "";

        public DataSet GetUsers(string username)
        {
            using (var connection = new SqlConnection(connstr))
            {
                string sql = "SELECT UserId, Username, FullName FROM Users WHERE Username= '"
                    + username + "' Order by Fullname";

                var adapter = new SqlDataAdapter(sql, connection);
                var result = new DataSet();
                adapter.Fill(result);

                return result;
            }
        }
    }
}