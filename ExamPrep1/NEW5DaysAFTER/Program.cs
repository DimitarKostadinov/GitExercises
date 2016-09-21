using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW5DaysAFTER
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month= int.Parse(Console.ReadLine());
            var date = new DateTime(2015, month, day).AddDays(5);
            Console.WriteLine("{0}.{1:D2}", date.Day, date.Month);

        }
    }
}
