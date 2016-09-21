using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var hometown = int.Parse(Console.ReadLine());
            var weekends = 48;
            var normalWeekends = (weekends - hometown) * (3.0 / 4);
            var play = holidays * (2.0 / 3) + normalWeekends;
            if (year == "leap") 
            {
                play = play+(play * 0.15)+hometown;
            }
            else if (year == "normal") 
            {
                play = play + hometown;
            }
            Console.WriteLine(Math.Truncate(play));



        }
    }
}
