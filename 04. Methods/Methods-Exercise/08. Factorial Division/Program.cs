using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());

            Factorial(firstNumber, secondNumber);
        }

        static void Factorial(double firstNumber, double secondNumber)
        {
            double firstFactorial = 1;
            double secondFactorial = 1;

            double sum = 0; 
            for (int i = 1; i <= firstNumber; i++)
            {
                firstFactorial *= i;
            }

            for (int i = 1; i <= secondNumber; i++)
            {
                secondFactorial *= i;
            }

            sum = firstFactorial / secondFactorial;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
