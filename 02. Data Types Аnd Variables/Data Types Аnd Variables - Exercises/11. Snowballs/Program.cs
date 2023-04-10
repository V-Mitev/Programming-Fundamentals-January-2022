using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxSnowballValue = -1;
            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballVolume = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballVolume > maxSnowballValue)
                {
                    maxSnowballValue = snowballVolume;
                    result = $"{snowballSnow} : {snowballTime} = {snowballVolume} ({snowballQuality})";
                }
            }

            Console.WriteLine(result);
        }
    }
}
