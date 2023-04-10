using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int totalPassagers = 0;
            int[] passagers = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                int passager = int.Parse(Console.ReadLine());
                passagers[i] = passager;

                totalPassagers += passagers[i];
            }
            Console.WriteLine(String.Join(" ", passagers));
            Console.WriteLine(totalPassagers);
        }
    }
}
