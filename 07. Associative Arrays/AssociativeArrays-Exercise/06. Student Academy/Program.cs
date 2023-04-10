using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
            int rowOfPairs = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rowOfPairs; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades[studentName].Add(grade);
                }
                else
                {
                    studentsGrades[studentName] = new List<double>();
                    studentsGrades[studentName].Add(grade);
                }
            }

            foreach (var student in studentsGrades)
            {
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:F2}");
                }
            }
        }
    }
}