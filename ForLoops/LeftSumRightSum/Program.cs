using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftSumRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var RightSum = 0;
            for (int i = 0; i < numbers; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers; i++)
            {
                RightSum = RightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum==RightSum)
            {
                Console.WriteLine("Yes, sum {0}",leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0} ",Math.Abs(leftSum-RightSum));
            }
        }
    }
}
