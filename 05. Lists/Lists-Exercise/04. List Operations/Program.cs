using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] strArgs = command.Split();

                string action = strArgs[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(strArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(strArgs[1]);
                    int indexToInsert = int.Parse(strArgs[2]);

                    if (indexToInsert >= 0 && indexToInsert < numbers.Count)
                    { 
                        numbers.Insert(indexToInsert, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Remove")
                {
                    int removeIndex = int.Parse(strArgs[1]);

                    if (removeIndex < numbers.Count && removeIndex >= 0)
                    {
                        numbers.RemoveAt(removeIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Shift")
                {
                    string direction = strArgs[1];
                    int count = int.Parse(strArgs[2]);

                    int realPerformedCount = count % numbers.Count;

                    if (direction == "left")
                    {
                        for (int i = 1; i <= realPerformedCount; i++)
                        {
                            if (count > 0)
                            {
                                int firstElement = numbers.First();

                                numbers.Remove(firstElement);

                                numbers.Add(firstElement);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        if (count > 0)
                        {
                            for (int i = 1; i <= realPerformedCount; i++)
                            {
                                int lastElement = numbers.Last();

                                numbers.RemoveAt(numbers.Count - 1);

                                numbers.Insert(0, lastElement);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}