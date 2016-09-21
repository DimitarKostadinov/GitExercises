using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var oddsum = 0;
            var evensum = 0;
            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evensum += number;
                }
                else
                {
                    oddsum += number;
                }
            }
            if (evensum==oddsum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",oddsum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(oddsum-evensum));

            }
        }
    }
}
