using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine())*100;
            var h = double.Parse(Console.ReadLine())*100;
            var cols = Math.Truncate((h - 100)/70);
            var rows = Math.Truncate((w) / 120);
            

            
            var mesta = (cols*rows) - 3;
            Console.WriteLine(mesta);

        }
    }
}
