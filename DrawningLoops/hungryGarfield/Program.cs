using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollars = double.Parse(Console.ReadLine());
            var rate = double.Parse(Console.ReadLine());
            var pizzaPrice = double.Parse(Console.ReadLine())/rate;
            var lasagnaPrice = double.Parse(Console.ReadLine())/rate;
            var sandwichPrice = double.Parse(Console.ReadLine())/rate;
            var pizzaQuantity = int.Parse(Console.ReadLine());
            var lasagnaQuantity = int.Parse(Console.ReadLine());
            var sandwichQuantity = int.Parse(Console.ReadLine());

            var sum = ((pizzaPrice * pizzaQuantity) + (lasagnaPrice * lasagnaQuantity) + (sandwichPrice * sandwichQuantity));
            if (dollars-sum>=0)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left:  ${0:f2}.", (dollars-sum));
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed   ${0:F2}.", Math.Abs(dollars - sum)); 
            }
           
        }
    }
}
