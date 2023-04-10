using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            MiddleCharacters(word);
        }

        static void MiddleCharacters(string word)
        {
            int middle = word.Length / 2;

            if (word.Length % 2 == 0)
            {
                Console.WriteLine($"{word[middle - 1]}{word[middle]}");
            }
            else
            {
                Console.WriteLine(word[middle]);
            }
        }
    }
}
