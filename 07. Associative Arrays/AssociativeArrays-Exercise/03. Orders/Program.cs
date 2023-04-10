using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> totalQuantity = new Dictionary<string, int>();
            Dictionary<string, decimal> totalPrice = new Dictionary<string, decimal>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string nameOfProduct = tokens[0];

                if (totalPrice.ContainsKey(nameOfProduct) && nameOfProduct != "buy")
                {
                    decimal priceOfProduct = decimal.Parse(tokens[1]);
                    int quantityOfProduct = int.Parse(tokens[2]);

                    totalQuantity[nameOfProduct] += quantityOfProduct;
                    totalPrice[nameOfProduct] = priceOfProduct;
                }
                else if (nameOfProduct != "buy")
                {
                    decimal priceOfProduct = decimal.Parse(tokens[1]);
                    int quantityOfProduct = int.Parse(tokens[2]);

                    decimal price = priceOfProduct;
                    int quantity = quantityOfProduct;

                    totalQuantity.Add(nameOfProduct, quantity);
                    totalPrice.Add(nameOfProduct, price);
                }
                else 
                {
                    foreach (var p in totalQuantity)
                    {
                        string product = p.Key;
                        int quantity = p.Value;
                        decimal price = totalPrice[product];
                        decimal results = quantity * price;

                        Console.WriteLine($"{product} -> {results:f2}");
                    }

                    break;
                }
            }
        }
    }
}
