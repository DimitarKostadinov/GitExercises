﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                var number=int.Parse(Console.ReadLine());
                if (number<min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
