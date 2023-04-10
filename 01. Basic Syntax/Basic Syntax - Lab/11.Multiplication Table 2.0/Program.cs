using System;

namespace _11.Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times <= 10)
            {

                for (int i = times; i <= 10; i++)
                {
                    int sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");

                }
            }
            else
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
            }
        }
    }
}
