using System;
using System.Linq;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool arraysAreIndentical = false;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];

                if (array1[i] != array2[i])
                {
                    arraysAreIndentical = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (!arraysAreIndentical)
            {
                arraysAreIndentical = true;
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
