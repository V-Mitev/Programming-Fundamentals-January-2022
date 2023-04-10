using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string products = Console.ReadLine();

                productsList.Add(products);
                productsList.Sort();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{productsList[i]}");
            }
        }
    }
}
