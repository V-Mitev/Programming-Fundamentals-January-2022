using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = CalculateRectangleArea(height, width);

            Console.WriteLine(area);
        }

        static double CalculateRectangleArea(double height, double width) 
        { 
            double area = height * width;

            return area;
        }
    }
}
