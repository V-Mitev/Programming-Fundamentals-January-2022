using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string typeOfDay = Console.ReadLine();

            double priceOfTicket = 0;
            double discountPercentage = 0;

            if (typeOfPeople == "Students")
            {
                if (countOfPeople >= 30)
                {
                    discountPercentage = 15;
                }

                if (typeOfDay == "Friday")
                {
                    priceOfTicket = 8.45;
                }
                else if (typeOfDay == "Saturday")
                {
                    priceOfTicket = 9.80;
                }
                else if (typeOfDay == "Sunday")
                {
                    priceOfTicket = 10.46;
                }
            }
            else if (typeOfPeople == "Business")
            {
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10;
                }

                if (typeOfDay == "Friday")
                {
                    priceOfTicket = 10.90;
                }
                else if (typeOfDay == "Saturday")
                {
                    priceOfTicket = 15.60;
                }
                else if (typeOfDay == "Sunday")
                {
                    priceOfTicket = 16;
                }
            }
            else if (typeOfPeople == "Regular")
            {
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    discountPercentage = 5;
                }

                if (typeOfDay == "Friday")
                {
                    priceOfTicket = 15;
                }
                else if (typeOfDay == "Saturday")
                {
                    priceOfTicket = 20;
                }
                else if (typeOfDay == "Sunday")
                {
                    priceOfTicket = 22.50;
                }
            }

            double totalPrice = countOfPeople * priceOfTicket;

            if (discountPercentage != 0)
            {
                totalPrice -= totalPrice * discountPercentage / 100;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
