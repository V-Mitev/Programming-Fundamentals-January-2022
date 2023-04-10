using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                if (currChar == '>')
                {
                    int currentBombPower = GetIntValueOfCharacter(input[i + 1]);

                    sb.Append(currChar);
                    bombPower += currentBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        sb.Append(currChar);
                    }
                }
            }

            Console.WriteLine(sb);
        }

        static int GetIntValueOfCharacter(char ch)
        {
            return (int)ch - 48;
        }
    }
}
