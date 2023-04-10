using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            MatrixNxN(input);
        }

        static void MatrixNxN(int input)
        {
            for (int col = 1; col <= input; col++)
            {
                for (int row = 1; row <= input; row++)
                {
                    Console.Write($"{input} ");
                }

                Console.WriteLine();
            }
        }
    }
}
