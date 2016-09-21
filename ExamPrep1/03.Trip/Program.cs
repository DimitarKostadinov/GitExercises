using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spend;
            if (budget<=100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season=="summer")
                {
                    spend = budget * 0.3;
                    Console.WriteLine("Camp - {0:F2}",spend);
                }
                else
                {
                    spend = budget * 0.7;
                    Console.WriteLine("Hotel - {0:F2}",spend);
                }

            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season=="summer")
                {
                    spend = budget * 0.4;
                    Console.WriteLine("Camp - {0:F2}",spend);
                }
                else
                {
                    spend = budget * 0.8;
                    Console.WriteLine("Hotel - {0:F2}", spend);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                spend = budget * 0.9;
                Console.WriteLine("Hotel - {0:F2}",spend);
            }
        }
    }
}
