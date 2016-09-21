using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    p1++;
                }
                if (num%3==0)
                {
                    p2++;
                }
                if (num%4==0)
                {
                    p3++;
                }
            }
            var p1inPercentage = p1 / n * 100.0;
            var p2inPercentage = p2 / n * 100.0;
            var p3inPercentage = p3 / n * 100.0;
            Console.WriteLine("{0:F2}%",p1inPercentage);
            Console.WriteLine("{0:F2}%", p2inPercentage);
            Console.WriteLine("{0:F2}%", p3inPercentage);
        }
    }
}
