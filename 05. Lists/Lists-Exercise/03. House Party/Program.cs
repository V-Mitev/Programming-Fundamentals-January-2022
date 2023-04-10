using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            List<string> partyList = new List<string>();

            for (int i = 1; i <= iterations; i++)
            {
                string[] checkPeople = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string memberName = checkPeople[0];

                if (checkPeople.Length == 3)
                {
                    if (partyList.Contains(memberName))
                    {
                        Console.WriteLine($"{memberName} is already in the list!");
                    }
                    else
                    {
                        partyList.Add(memberName);
                    }
                }

                if (checkPeople.Length == 4)
                {
                    if (partyList.Contains(memberName))
                    {
                        partyList.Remove(memberName);
                    }
                    else
                    {
                        Console.WriteLine($"{memberName} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < partyList.Count; i++)
            {
                Console.WriteLine($"{partyList[i]}");
            }
        }
    }
}
