using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            bool n = false;
            double sum = 0;
            double total = 0;
            while (!n)
            {
                for (int i = 1; i <= countOrders; i++)
                {
                    double priceForCapsule = double.Parse(Console.ReadLine());
                    int days = int.Parse(Console.ReadLine());
                    int capsuleCount = int.Parse(Console.ReadLine());

                    sum = days * capsuleCount * priceForCapsule;
                    Console.WriteLine($"The price for the coffee is: ${sum:F2}");
                    n = true;
                    total += sum;
                }
            }

            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
