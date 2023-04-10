using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int lines = 1; lines <= input; lines++)
            {
                for (int number = 1; number <= lines; number++)
                {
                    Console.Write($"{lines} ");
                }
                Console.WriteLine();
            }
        }
    }
}
