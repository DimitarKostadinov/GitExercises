using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_or_veggie
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = Console.ReadLine().ToLower();
            if (i == "banana" || i == "apple" || i == "kiwi" || i == "cherry" || i == "lemon" || i == "grapes") Console.WriteLine("fruit");
            else if (i == "tomato" || i == "cucumber" || i == "pepper" || i == "carrot") Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");
        }
    }
}
