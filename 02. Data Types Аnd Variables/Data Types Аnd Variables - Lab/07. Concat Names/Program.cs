using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            string ch = Console.ReadLine();

            Console.WriteLine($"{name}{ch}{family}");
        }
    }
}
