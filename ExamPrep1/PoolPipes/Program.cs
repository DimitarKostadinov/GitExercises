using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int pool = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
           double hour = double.Parse(Console.ReadLine());
            var water = (pipe1*hour + pipe2*hour);

            if (water<=pool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%. ", 
                    Math.Truncate((water/pool)*100),
                    Math.Truncate(pipe1*hour/water*100),
                    Math.Truncate(pipe2*hour/water*100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hour,water-pool);
            }


            
        }
    }
}
