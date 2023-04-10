using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";

            string input = Console.ReadLine();
            List<string> furnitureInfo = new List<string>();
            double moneySpend = 0;

            Regex regex = new Regex(pattern);

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitureInfo.Add(furnitureName);
                    moneySpend += pricePerUnit * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");

            foreach (string furnitureName in furnitureInfo)
            {
                Console.WriteLine(furnitureName);
            }

            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}