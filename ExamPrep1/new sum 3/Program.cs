using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_sum_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            var max=Math.Max(first,Math.Max(second,third));
            var min = Math.Min(first, Math.Min(second, third));
            var sum = first + second + third;
            var middle = sum - max - min;

            if (min+second<=max)
            {
                Console.WriteLine("{0}+{1}={2}", min,middle,max);
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
