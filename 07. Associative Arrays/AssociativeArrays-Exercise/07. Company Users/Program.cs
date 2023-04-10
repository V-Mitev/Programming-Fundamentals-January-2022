using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> companyIndentificator = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] cmdArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string companyName = cmdArgs[0];
                string employeId = cmdArgs[1];

                if (!companyIndentificator.ContainsKey(companyName))
                {
                    companyIndentificator[companyName] = new List<string>();
                }

                if (!companyIndentificator[companyName].Contains(employeId))
                {
                    companyIndentificator[companyName].Add(employeId);
                }

                command = Console.ReadLine();
            }

            foreach (var company in companyIndentificator)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"--{employee}");
                }
            }
        }
    }
}
