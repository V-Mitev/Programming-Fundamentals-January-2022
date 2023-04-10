using System;
using System.Text;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sb = Console.ReadLine();
            int countOfRepeats = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(sb, countOfRepeats));
        }

        static string RepeatString(string template, int countRepeats) 
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= countRepeats; i++)
            {
                sb.Append(template);
            }

            return sb.ToString();
        }

    }
}
