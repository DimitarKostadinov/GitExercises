using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var presentPrice = int.Parse(Console.ReadLine());
            var moneyFromPresent = 0;
            var bonus = 10;
            var savings = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    
                    savings = savings + bonus;
                    savings = savings - 1;
                    bonus = bonus + 10;

                }
                else
                {
                    moneyFromPresent += presentPrice;
                }
            }
            var allMoney = moneyFromPresent + savings;
            if (allMoney >= price)
            {
                Console.WriteLine("Yes! {0:F2}", allMoney - price);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", Math.Abs(allMoney - price));
            }
        }
    }
}
