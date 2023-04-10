using System;

namespace _9.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int currentOddNumber = 1 + (i * 2);
                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
