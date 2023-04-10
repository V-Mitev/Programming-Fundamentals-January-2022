using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            Calculate(firstNumber, @operator, secondNumber);
        }

        static void Calculate(int firstNumber, string @operator, int secondNumber)
        {
            int result = 0;

            if (@operator == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine(result);
            }
            else if(@operator == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine(result);
            }
            else if (@operator == "*")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine(result);
            }
            else
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
        }
    }
}
