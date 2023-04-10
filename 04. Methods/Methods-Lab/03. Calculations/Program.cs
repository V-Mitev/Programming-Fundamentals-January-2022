using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfOperations = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            if (typeOfOperations == "add")
            {
                AddNumbers(firstNumber, secondNumber, sum);
            }
            else if (typeOfOperations == "subtract")
            {
                SubtractNumbers(firstNumber, secondNumber, sum);
            }
            else if (typeOfOperations == "multiply")
            {
                MultiplyNumbers(firstNumber, secondNumber, sum);
            }
            else if (typeOfOperations == "divide")
            {
                DivideNumbers(firstNumber, secondNumber, sum);
            }
        }

        static void AddNumbers(int firstNumber, int secondNumber, int sum)
        {
                sum = firstNumber + secondNumber;
                Console.WriteLine(sum);   
        }

        static void MultiplyNumbers(int firstNumber, int secondNumber, int sum)
        {
                sum = firstNumber * secondNumber;
                Console.WriteLine(sum);   
        }

        static void SubtractNumbers(int firstNumber, int secondNumber, int sum)
        {
            sum = firstNumber - secondNumber;
            Console.WriteLine(sum);
        }

        static void DivideNumbers(int firstNumber, int secondNumber, int sum)
        {
            sum = firstNumber / secondNumber;
            Console.WriteLine(sum);
        }
    }
}
