using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспалива_Котка
{
    class Program
    {
        static void Main(string[] args)
        {
            var freedays = int.Parse(Console.ReadLine());
            var workdays=365-freedays;
            var Playtime = workdays * 63 + freedays * 127;

            var differences = Playtime - 30000;
            var hours = Math.Abs(differences / 60);
            var minutes = Math.Abs(differences % 60);

            if (Playtime>30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,minutes);
            }


        }
    }
}
