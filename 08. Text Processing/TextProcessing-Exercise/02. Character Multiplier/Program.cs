using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];

            GetSumOfStrings(firstString, secondString);
        }

        static void GetSumOfStrings(string firstString, string secondString)
        {
            int minLenghtString = Math.Min(firstString.Length, secondString.Length);
            int sum = 0;

            for (int i = 0; i < minLenghtString; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            string longerLenghtString = firstString;

            if (longerLenghtString.Length < secondString.Length)
            {
                longerLenghtString = secondString;
            }

            for (int i = minLenghtString; i < longerLenghtString.Length; i++)
            {
                sum += longerLenghtString[i];
            }

            Console.WriteLine(sum);
        }
    }
}
