using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i < height; i++)
            {
                PrintTriangle(1, i);
            }

            for (int j = height; j >= 1; j--)
            {
                PrintTriangle(1, j);
            }
        }

        static void PrintTriangle(int start, int end) 
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

    }
}