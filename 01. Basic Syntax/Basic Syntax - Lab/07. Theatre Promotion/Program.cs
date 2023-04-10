using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDays = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());

            double priceOfTicket = 0;

            if (age >= 0 && age <= 18)
            {

                if (typeOfDays == "Weekday")
                {
                    priceOfTicket = 12;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDays == "Weekend")
                {
                    priceOfTicket = 15;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDays == "Holiday")
                {
                    priceOfTicket = 5;
                    Console.WriteLine($"{priceOfTicket}$");
                }
            }
            else if (age > 18 && age <= 64)
            {

                if (typeOfDays == "Weekday")
                {
                    priceOfTicket = 18;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDays == "Weekend")
                {
                    priceOfTicket = 20;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDays == "Holiday")
                {
                    priceOfTicket = 12;
                    Console.WriteLine($"{priceOfTicket}$");
                }
            }
            else if (age > 64 && age <= 122)
            {

                if (typeOfDays == "Weekday")
                {
                    priceOfTicket = 12;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDays == "Weekend")
                {
                    priceOfTicket = 15;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDays == "Holiday")
                {
                    priceOfTicket = 10;
                    Console.WriteLine($"{priceOfTicket}$");
                }
            }
            else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
}