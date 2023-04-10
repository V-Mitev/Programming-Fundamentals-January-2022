using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int capacityOfTank = 255;
            int sumOfWater = 0;

            for (int i = 1; i <= input; i++)
            {
                int quantityOfTank = int.Parse(Console.ReadLine());

                if (quantityOfTank <= capacityOfTank)
                {
                    sumOfWater += quantityOfTank;

                    if (sumOfWater > capacityOfTank )
                    {
                        Console.WriteLine("Insufficient capacity!");
                        sumOfWater -= quantityOfTank;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sumOfWater);
        }
    }
}
