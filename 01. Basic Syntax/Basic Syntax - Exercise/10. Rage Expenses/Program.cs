using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double dsiplayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int dsiplayCount = 0;

            for (int i = 1; i <= gameLost; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }

                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 6 == 0)
                {
                    keyboardCount++;
                }

                if (i % 12 == 0)
                {
                    dsiplayCount++;
                }
            }

            double rageExpenses = mousePrice * mouseCount +
                                  keyboardPrice * keyboardCount +
                                  dsiplayCount * dsiplayPrice +
                                  headsetCount * headsetPrice;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
