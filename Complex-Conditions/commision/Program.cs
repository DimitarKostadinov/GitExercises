using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commision
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());
            var comissions =-1.0;
            if (city == "sofia")
            {

                if (0 <= s && s <= 500) comissions = 0.05;
                else if (500 <= s && s <= 1000) comissions = 0.07;
                else if (1000<= s && s <= 10000) comissions = 0.08;
                else if (s > 10000) comissions = 0.12;   
            }

            if (city == "varna")
            {

                if (0 <= s && s <= 500) comissions = 0.045;
                else if (500 <= s && s <= 1000) comissions = 0.075;
                else if (1000 <= s && s <= 10000) comissions = 0.1;
                else if (s > 10000) comissions = 0.13;
            }
            if (city == "plovdiv")
            {

                if (0 <= s && s <= 500) comissions = 0.055;
                else if (500 <= s && s <= 1000) comissions = 0.08;
                else if (1000 <= s && s <= 10000) comissions = 0.12;
                else if (s > 10000) comissions = 0.145;
            }
            if (comissions >= 0)
            {
                Console.WriteLine("{0:f2}", (comissions * s));
            }
            else Console.WriteLine("Error!");




        }
    }
}
