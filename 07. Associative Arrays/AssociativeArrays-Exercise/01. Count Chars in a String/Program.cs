using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> countChars = new Dictionary<char, int>();


            foreach (var ch in text)
            {
                if (countChars.ContainsKey(ch))
                {
                    countChars[ch]++;
                }
                else
                {
                    countChars.Add(ch, 1);
                }
            }

            foreach (var ch in countChars.Where(a => a.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> { ch.Value}");
            }
        }
    }
}
