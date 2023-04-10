using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>(\d{2}))(?<separators>(.|/|-))(?<month>(\w{3}))\k<separators>(?<years>(\d{4}))";

            MatchCollection dates = Regex.Matches(input, pattern);

            foreach (Match match in dates)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["years"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}