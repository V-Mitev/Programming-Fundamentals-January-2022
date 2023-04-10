using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int[] topIntegers = new int[array.Length];
            int topIntegerIndex = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                int currentNum = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    int nextNum = array[j];

                    if (nextNum >= currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers[topIntegerIndex] = currentNum;
                    topIntegerIndex++;
                }
            }

            for (int i = 0; i < topIntegerIndex; i++)
            {
                int currentTopInteger = topIntegers[i];
                Console.Write($"{currentTopInteger} ");
            }
        }
    }
}
