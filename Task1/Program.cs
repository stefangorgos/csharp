using System.Text.RegularExpressions;

namespace Task1
{
    internal class Program
    {
        static string GetColor(string cell)
        {
            if (Regex.IsMatch(cell, "^[A-Ha-h][1-8]$"))
            {
                return (cell[0] + cell[1]) % 2 == 1 ? "white" : "black";  
            }
            return "invalid cell format";

        }

        static void Main(string[] args)
        {           
            Console.Write("enter the desired cell: ");
            string cell = Console.ReadLine();
            string result = GetColor(cell);
            Console.WriteLine(result);
        }
    }
}