using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char firstLetter = input[0];

            Console.Write(firstLetter);

            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (firstLetter != currentChar)
                {
                    firstLetter = currentChar;
                    Console.Write(firstLetter);
                }
            }
        }
    }
}
