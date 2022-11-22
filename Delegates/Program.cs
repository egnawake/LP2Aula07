using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void PrintUpper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }

        public static void PrintLower(string s)
        {
            Console.WriteLine(s.ToLower());
        }
    }
}
