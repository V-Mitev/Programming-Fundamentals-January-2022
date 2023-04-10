using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split();
                string actions = token[0];

                if (actions == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                }
                else if (actions == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (actions == "RemoveAt")
                {
                    int removeAtIndex = int.Parse(token[1]);
                    numbers.RemoveAt(removeAtIndex);
                }
                else if (actions == "Insert")
                {
                    int numberToInsert = int.Parse(token[1]);
                    int indexToInsert = int.Parse(token[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
