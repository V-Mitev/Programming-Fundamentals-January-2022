using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int amountOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            int lightsabers = (int)Math.Ceiling(amountOfStudents * 1.1);
            double belts = amountOfStudents - amountOfStudents / 6;

            double totalPrice = priceOfLightsabers * lightsabers +
                                priceOfBelts * belts +
                                amountOfStudents * priceOfRobes;

            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - amountOfMoney):F2}lv more.");
            }
        }
    }
}
