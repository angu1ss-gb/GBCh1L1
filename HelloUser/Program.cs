using System;
using System.Text;

namespace HelloUser
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter name");
            var name  = Console.ReadLine();
            Console.WriteLine($"Hey, {name}. Today is {DateTime.Now:dd.MM.yyyy}");
            // User-friendly app finish
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to close application...");
            Console.Read();
        }
    }
}