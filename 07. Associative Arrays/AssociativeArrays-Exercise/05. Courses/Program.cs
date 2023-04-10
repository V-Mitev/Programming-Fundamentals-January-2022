using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsInCourse = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (studentsInCourse.ContainsKey(courseName))
                {
                    studentsInCourse[courseName].Add(studentName);
                }
                else
                {
                    studentsInCourse[courseName] = new List<string>();
                    studentsInCourse[courseName].Add(studentName);
                }

                command = Console.ReadLine();
            }

            foreach (var csp in studentsInCourse)
            {
                Console.WriteLine($"{csp.Key}: {csp.Value.Count}");

                foreach (var names in csp.Value)
                {
                    Console.WriteLine($"-- {names}");
                }
            }
        }
    }
}
