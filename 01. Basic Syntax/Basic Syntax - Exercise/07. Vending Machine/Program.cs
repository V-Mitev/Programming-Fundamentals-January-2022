using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            string products = string.Empty;

            double sum = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins =double.Parse(input);

                if (coins == 0.1)
                {
                    sum += coins;
                }
                else if (coins == 0.2)
                {
                    sum += coins;
                }
                else if (coins == 0.5)
                {
                    sum += coins;
                }
                else if (coins == 1.0)
                {
                    sum += coins;
                }
                else if (coins == 2.0)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
            }

            while ((products = Console.ReadLine()) != "End")
            {
                if (products == "Nuts")
                {
                    if (sum < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 2.0;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                }
                else if (products == "Water")
                {
                    if (sum < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 0.7;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                }
                else if (products == "Crisps")
                {
                    if (sum < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 1.5;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                }
                else if (products == "Soda")
                {
                    if (sum < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 0.8;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                }
                else if (products == "Coke")
                {
                    if (sum < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        sum -= 1;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
