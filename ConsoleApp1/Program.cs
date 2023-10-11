namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string sql = "SELECT * FROM Users WHERE Id = " + args[0];
        }
    }
}