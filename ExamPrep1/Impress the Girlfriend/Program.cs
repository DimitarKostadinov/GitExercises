using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impress_the_Girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            uint r=uint.Parse(Console.ReadLine());
            uint d=uint.Parse(Console.ReadLine());
            uint e=uint.Parse(Console.ReadLine());
            uint b=uint.Parse(Console.ReadLine());
            uint m=uint.Parse(Console.ReadLine());
            
            var roubla = (r / 100)*3.5;
            var dollars = d * 1.5;
            var euro = e * 1.95;
            var B = b / 2;
            
            
            
            
            Console.WriteLine("{0:f2}",Math.Ceiling(Math.Max(roubla,Math.Max(dollars,Math.Max(euro,Math.Max(B,m))))));
        }
    }
}
