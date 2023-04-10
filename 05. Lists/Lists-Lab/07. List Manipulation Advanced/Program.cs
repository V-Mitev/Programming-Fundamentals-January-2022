using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool hasChanges = false;

            while (command != "end")
            {
                string[] token = command.Split();
                string actions = token[0];

                if (actions == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                    hasChanges = true;
                }
                else if (actions == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                    hasChanges = true;
                }
                else if (actions == "RemoveAt")
                {
                    int removeAtIndex = int.Parse(token[1]);
                    numbers.RemoveAt(removeAtIndex);
                    hasChanges = true;
                }
                else if (actions == "Insert")
                {
                    int numberToInsert = int.Parse(token[1]);
                    int indexToInsert = int.Parse(token[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    hasChanges = true;
                }
                else if (actions == "Contains")
                {
                    int numberToContains = int.Parse(token[1]);

                    if (numbers.Contains(numberToContains))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (actions == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (actions == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (actions == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }
                else if (actions == "Filter")
                {
                    string conditions = token[1];
                    int numberToCompare = int.Parse(token[2]);

                    List<int> result = FilteredNumbers(numbers, conditions, numberToCompare);
                    Console.WriteLine(string.Join(" ", result));
                }

                command = Console.ReadLine();
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> FilteredNumbers(List<int> numbers, string condition, int numberToCompare)
        {
            if (condition == "<")
            {
               List<int> result = numbers.FindAll(x => x < numberToCompare);
                return result;
            }
            else if (condition == ">")
            {
                List<int> result = numbers.FindAll(x => x > numberToCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = numbers.FindAll(x => x <= numberToCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = numbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            else
            {
                return numbers;
            }
        }
    }
}