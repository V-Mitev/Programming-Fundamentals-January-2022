using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            while (input > 0)
            {
                int realNumber = input % 10;

                sum += realNumber;

                input /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
