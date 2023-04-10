using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> result = new List<string>();

            foreach (Match number in matches)
            {
                result.Add(number.Value);
            }

            Console.Write(string.Join(", ", result));
        }
    }
}
