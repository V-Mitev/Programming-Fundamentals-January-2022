using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double powerResult = MathPower(number, power);
            Console.WriteLine(powerResult);
        }

        static double MathPower(double number, int power) 
        {
            double result = number;

            for (int i = 1; i < power; i++)
            {
                result = result * number;
            }

            return result;
        }
    }
}
