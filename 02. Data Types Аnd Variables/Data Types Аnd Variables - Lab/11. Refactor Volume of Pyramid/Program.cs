using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Lenght = double.Parse(Console.ReadLine());
            double volume = (width * height * Lenght) / 3;

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
