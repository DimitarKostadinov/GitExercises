using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablePrice = double.Parse(Console.ReadLine());
            var  fruitPrice= double.Parse(Console.ReadLine());
            var vegetableQuantity = int.Parse(Console.ReadLine());
            var fruitQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine(((vegetablePrice*vegetableQuantity)+(fruitPrice*fruitQuantity))/1.94);
        }
    }
}
