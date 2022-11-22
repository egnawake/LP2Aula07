using System;

namespace Delegates
{
    public class Joiner
    {
        private readonly string firstString;

        public Joiner(string firstString)
        {
            this.firstString = firstString;
        }

        public void JoinAndPrint(string secondString)
        {
            Console.WriteLine(firstString + secondString);
        }
    }
}