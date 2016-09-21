using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace border
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine();
            var quantity=double.Parse(Console.ReadLine());
            var price=-1.0;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "thursday" || day == "friday"){
                if (fruit == "banana") price = 2.50;
                if (fruit == "apple") price = 1.20;
                if (fruit == "orange") price = 0.85;
                if (fruit == "grapefruit") price = 1.45;
                if (fruit == "kiwi") price = 2.70;
                if (fruit == "pineapple") price = 5.50;
                if (fruit == "grapes") price = 3.85;
                if (price >= 0) Console.WriteLine("{0:f2}", price * quantity);
                
            }

            if(day == "Saturday" || day == "Sunday"){
                if (fruit == "banana") price=2.50;
                if (fruit == "apple") price=1.25;
                if (fruit == "orange") price=0.90;
                if (fruit == "grapefruit") price=1.60;
                if (fruit == "kiwi") price=3.00;
                if (fruit == "pineapple") price=5.60;
                if (fruit == "grapes") price = 4.20;
                if (price >= 0) Console.WriteLine("{0:f2}", price * quantity);
            }
            
            
    }
    }
}
