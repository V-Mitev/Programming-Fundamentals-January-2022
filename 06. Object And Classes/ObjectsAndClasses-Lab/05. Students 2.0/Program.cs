using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                bool doesStudentExist = DoesStudentExist(students, firstName, lastName);

                if (doesStudentExist)
                {
                    Student existingStudent = students.FirstOrDefault(students => students.FirstName == firstName
                    && students.LastName == lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;

                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);

                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string homeTownToSearch = Console.ReadLine();

            List<Student> filteredStudents = students.FindAll(student => student.HomeTown == homeTownToSearch);

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
