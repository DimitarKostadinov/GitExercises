using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var o = int.Parse(Console.ReadLine());

            var area = n * n;
            var peika = m * o;
            var plochka = w * l;
            var neededbricks=(area-peika)/plochka;
            var neededtime=neededbricks*0.2;
            Console.WriteLine(neededbricks);
            Console.WriteLine(neededtime);

        }
    }
}
