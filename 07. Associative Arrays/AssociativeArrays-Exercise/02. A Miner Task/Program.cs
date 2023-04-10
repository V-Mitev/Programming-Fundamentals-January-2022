using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourcesCmd = Console.ReadLine();

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resourcesCmd != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resourcesCmd))
                {
                    resources[resourcesCmd] += quantity;
                }
                else
                {
                    resources[resourcesCmd] = quantity;
                }

                resourcesCmd = Console.ReadLine();
            }

            foreach (var rqp in resources)
            {
                Console.WriteLine($"{rqp.Key} -> {rqp.Value}");
            }
        }
    }
}
