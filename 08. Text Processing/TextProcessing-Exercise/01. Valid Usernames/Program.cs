using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string currUsername in usernames)
            {
                if (currUsername.Length >= 3 && currUsername.Length <= 16)
                {
                    bool isNameValid = true;

                    foreach (char currChar in currUsername)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '_' || currChar == '-'))
                        {
                            isNameValid = false;
                            break;
                        }
                    }

                    if (isNameValid)
                    {
                        Console.WriteLine(currUsername);
                    }
                }
            }
        }
    }
}