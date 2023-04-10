using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int n = numbers[i];

                if (n % 2 == 0)
                {
                    evenSum += n;
                }
                else
                {
                    oddSum += n;
                }
            }

            result = evenSum - oddSum;

            Console.WriteLine(result);
        }
    }
}
