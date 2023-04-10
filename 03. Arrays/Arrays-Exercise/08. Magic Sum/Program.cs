using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int number1 = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int number2 = arr[j];

                    int sum = number1 + number2;

                    if (sum == number)
                    {
                        Console.WriteLine(String.Join(' ', number1, number2));
                    }
                }
            }
        }
    }
}