﻿using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int numbers = input[i];

                if (numbers % 2 == 0)
                {
                    sum += numbers;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
