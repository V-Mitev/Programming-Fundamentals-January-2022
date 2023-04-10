using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SumOfFirstTwoNumbersAndSubtarctThemWithThird(firstNumber, secondNumber, thirdNumber));
        }

        static int SumOfFirstTwoNumbersAndSubtarctThemWithThird(int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber + secondNumber - thirdNumber;
        }
    }
}
