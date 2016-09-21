using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5daysAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            var daysInMonth = 0;
            if (month==4 && month==6 && month==9 && month==11)
            {
                daysInMonth = 30;
            }
            else if (month==2)
            {
                daysInMonth = 28;
            }
            else
            {
                daysInMonth = 31;
            }
            day += 5;
            if (day>daysInMonth)
            {
                day = day - daysInMonth;
                month = (month % 12) + 1;
            }
            if (month<=9)
            {
                Console.WriteLine("{0}.0{1}",day,month);

            }
            else
            {
                Console.WriteLine("{0}.{1}",day,month);
            }

        }
    }
}
