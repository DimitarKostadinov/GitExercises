using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //Top Part
            Console.Write("+");
            for (int col = 0; col < n-2; col++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            
            //Middle Part
            for (int row = 0; row < n - 2; row++)
            {


                Console.Write("|");
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }



            //Bottom Part
            Console.Write("+");
            for (int col = 0; col < n - 2; col++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");



        }
    }
}
