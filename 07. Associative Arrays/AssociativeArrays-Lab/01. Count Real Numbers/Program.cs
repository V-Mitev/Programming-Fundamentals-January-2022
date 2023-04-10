using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> occurenses = new SortedDictionary<int, int>();


            foreach (var number in numbers)
            {
                if (occurenses.ContainsKey(number))
                {
                    occurenses[number]++;
                }
                else
                {
                    occurenses[number] = 1;
                }
            }

            foreach (var number in occurenses)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
