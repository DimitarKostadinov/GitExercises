using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int max=Math.Max(first,Math.Max(second,third));
            int min = Math.Min(first, Math.Min(second, third));
            int sum = first + second + third;
            var middle = sum - max - min;

            if (min+second<=max)
            {
         
                Console.WriteLine("{0}+{1}={2}",first,second,max);
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
