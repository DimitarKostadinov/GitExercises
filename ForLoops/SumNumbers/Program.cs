using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < num; i++)
            {
                var currentsum = int.Parse(Console.ReadLine());
                sum += currentsum;
            }
            Console.WriteLine(sum);
        }
    }
}
