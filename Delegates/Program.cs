using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Action<string> op = PrintUpper;
            op += PrintLower;
            
            Joiner j = new Joiner("abc");
            op += j.JoinAndPrint;

            op.Invoke("Test");
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
