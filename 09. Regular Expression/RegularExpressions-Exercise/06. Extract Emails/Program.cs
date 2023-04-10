using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s)(?<user>(?![_])[A-za-z0-9]+(?:[\.\-_][A-za-z0-9]+)*)@(?<host>[a-zA-Z]+(?:[\-][a-zA-z]+)*(?:\.[a-zA-Z]+(?:[\-][a-zA-Z]+)*)*\.[a-z]+)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            if (regex.IsMatch(text))
            {
                foreach (Match email in matches)
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}
