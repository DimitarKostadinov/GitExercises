using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();
            var taxiPrice = 0.90;
            if (dayOrNight=="day") taxiPrice=0.79;
            var busPrice = 0.09;
            var trainPrice = 0.06;

            
            if (distance<20)
            {
                    Console.WriteLine("Taxi {0}",(distance*taxiPrice)+0.70);
            }
            else if (distance<100)
            {
                Console.WriteLine("Bus {0}",distance*busPrice );
            }
            else
            {
                Console.WriteLine("Train {0}",distance*trainPrice);
            }
            
        
        }
            
            
        }
    }
