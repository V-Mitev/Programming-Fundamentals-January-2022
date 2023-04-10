using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int caapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)peopleCount / caapacity);

            Console.WriteLine(courses);
        }
    }
}
