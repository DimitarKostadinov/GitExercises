﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            var p4 = 0;
            var p5 = 0;
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<200)
                {
                    p1++;
                }
                else if (number <400 )
                {
                    p2++;
                }
                else if (number<600)
                {
                    p3++;
                }
                else if (number<800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            var total = (p1 + p2 + p3 + p4 + p5) * 1.0;
            Console.WriteLine("{0:F2}%",(p1 / total) * 100);
            Console.WriteLine("{0:F2}%",(p2 / total) * 100);
            Console.WriteLine("{0:F2}%",(p3 / total) * 100);
            Console.WriteLine("{0:F2}%",(p4 / total) * 100);
            Console.WriteLine("{0:F2}%",(p5 / total) * 100);
        }

    }
}
