using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briks
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var cartVolume = int.Parse(Console.ReadLine());
            var totalCart=workers*cartVolume;
            var totalbricks=0;
            var courses = 0;
            while (totalbricks<bricks)
            {
                courses++;
                totalbricks = totalbricks + totalCart;

            }
           
            if (bricks==0||workers==0||cartVolume==0)
            {
                courses = 0;
            }
            Console.WriteLine(courses);
            


        }
    }
}
