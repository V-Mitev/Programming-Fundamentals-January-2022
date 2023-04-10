using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minLength = 6;
            const int maxLength = 10;
            const int minDigitsCount = 2;

            string password = Console.ReadLine();

            bool passwordIsValid = IsPasswordIsValid(password, minLength, maxLength, minDigitsCount);

            if (passwordIsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordIsValid(string password, int minLength, int maxLength, int minDigitsCount)
        {
            bool isValid = true;


            if (!IsLenghtIsValid(password, minLength, maxLength))
            {
                Console.WriteLine($"Password must be between {minLength} and {maxLength} characters");
                isValid = false;
            }

            if (!IsPasswordContainsLettersAndDigitsOnly(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!IsPasswordContainsMinimumDigits(password, minDigitsCount))
            {
                Console.WriteLine($"Password must have at least {minDigitsCount} digits");
                isValid = false;
            }

            return isValid;
        }

        static bool IsLenghtIsValid(string password, int minLength, int maxLength)
        {
            if (password.Length >= minLength && password.Length <= maxLength)
            {
                return true;
            }

            return false;
        }

        static bool IsPasswordContainsLettersAndDigitsOnly(string password)
        {
            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsPasswordContainsMinimumDigits(string password, int minDigits)
        {
            int digitCounter = 0;

            foreach (char digit in password)
            {
                if (Char.IsDigit(digit))
                {
                    digitCounter++;
                }
            }

            return digitCounter >= minDigits;
        }
    }
}
