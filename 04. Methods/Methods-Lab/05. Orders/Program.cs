using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculatePriceOfProducts(product, quantity);
        }

        static void CalculatePriceOfProducts(string typeOfProduct, int quantity)
        {
            double sum = 0;

            if (typeOfProduct == "coffee")
            {
                sum = quantity * 1.50;
                Console.WriteLine($"{sum:F2}");
            }
            else if (typeOfProduct == "water")
            {
                sum = quantity * 1.00;
                Console.WriteLine($"{sum:F2}");
            }
            else if (typeOfProduct == "coke")
            {
                sum = quantity * 1.40;
                Console.WriteLine($"{sum:F2}");
            }
            else if (typeOfProduct == "snacks")
            {
                sum = quantity * 2.00;
                Console.WriteLine($"{sum:F2}");
            }
        }
    }
}
