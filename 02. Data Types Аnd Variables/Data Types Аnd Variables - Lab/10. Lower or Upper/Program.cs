using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            string lowerLetter = letters.ToLower();
            string upperLetter = letters.ToUpper();

            if (letters == lowerLetter)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
