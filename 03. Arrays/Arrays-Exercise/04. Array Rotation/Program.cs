using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());

            int reducedCountRotations = rotationsCount % array.Length;

            for (int i = 1; i <= reducedCountRotations; i++)
            {
                int firstEl = array[0];

                for (int j = 0; j <= array.Length - 2; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstEl;
            }

            Console.WriteLine(String.Join(' ', array));
        }
    }
}
