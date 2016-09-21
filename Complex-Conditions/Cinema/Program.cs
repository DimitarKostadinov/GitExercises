using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());
            double sum = -1.00;
            var premiere = 12.00;
            var normal = 7.50;
            var discount = 5.00;
            if(type=="premiere"){
                sum = Math.Round((row * column) * premiere,2);
                

                Console.WriteLine("{0} leva",sum);
            }
            else if (type == "normal") {
                sum = Math.Round((row * column) * normal, 2);
                Console.WriteLine("{0} leva", sum);
            }
            else if (type == "discount") 
            {
            
                sum = Math.Round((row * column) * discount, 2);
                Console.WriteLine("{0} leva", sum);
            }


        }
    }
}
