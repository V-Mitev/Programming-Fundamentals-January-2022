using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char frstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintFromASCII(frstChar, secondChar);
        }

        static void PrintFromASCII(char first, char second)
        {
            int counter = first + 1;
            int secondCounter = second + 1;

            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    Console.Write($"{(char)counter} ");
                    counter++;
                }
            }
            else
            {
                for (int i = second + 1; i < first; i++)
                {
                    Console.Write($"{(char)secondCounter} ");
                    secondCounter++;
                }
            }
        }
    }
}
