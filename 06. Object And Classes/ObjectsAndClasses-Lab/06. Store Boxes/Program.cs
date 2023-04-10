using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Box
    {
        public string SerialNumber { get; set; }

        public string Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceBox { get; set; }

        public decimal TotalPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal priceBox = decimal.Parse(tokens[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item = itemName;
                box.Quantity = itemQuantity;
                box.PriceBox = priceBox;
                box.TotalPrice = itemQuantity * priceBox;

                boxes.Add(box);

                command = Console.ReadLine();
            }

            List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceBox:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }
}
