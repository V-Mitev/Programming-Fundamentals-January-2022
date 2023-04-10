using System;
using System.Numerics;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal sumOfNumbers = 0;

            for (int i = 1; i <= input; i++)
            {
                sumOfNumbers += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}
