using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int result = VowelsCount(word);

            Console.WriteLine(result);
        }

        static int VowelsCount(string word)
        {
            char[] vowels = new char [] {'a', 'o', 'e', 'i', 'u' };
            int vowelsCount = 0;

            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
