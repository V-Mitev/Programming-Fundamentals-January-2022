﻿using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] {"Excellent product.", 
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.", 
                "I can’t live without this product." };

            string[] events = new string[] { "Now I feel good.",
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrase = new Random();
            Random event1 = new Random();
            Random author = new Random();
            Random town = new Random();

            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int phraseIndex = phrase.Next(0, phrases.Length);    
                int event1Index = event1.Next(0, events.Length);    
                int authorIndex = author.Next(0, authors.Length);    
                int townIndex = town.Next(0, city.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[event1Index]} {authors[authorIndex]} - {city[townIndex]}");
            }
        }
    }
}
