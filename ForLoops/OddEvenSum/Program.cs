using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            Oddsum = 0;
            Evensum = 0;

            
            for (int i = 1; i <=count; i++)
            {
            
                var number=int.Parse(Console.ReadLine());
                if (i%2 ==0)
                {
                    Evensum += number; 
                }
                else
                {
                    Oddsum += number;
                }
            }
        }
    }
}
