using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            var result=0;
            if (operation=="+")
            {
                result=n1+n2;
                Console.Write("{0} + {1} = {2} - ",n1,n2,result);
                Console.WriteLine((n1+n2)%2==0? "even":"odd");
            }
            else if (operation=="-")
            {
                result=n1-n2;
                Console.Write("{0} - {1} = {2} - ",n1,n2,result);
                Console.WriteLine((n1-n2)%2==0? "even":"odd");
            }
            else if (operation=="*")
            {
                result=n1*n2;
                Console.Write("{0} * {1} = {2} - ",n1,n2,result);
                Console.WriteLine((n1*n2)%2==0? "even":"odd");
            }
            else if (operation=="/")
            {
                if (n2>0)
                {
                    
                    double n11 = (double)n1;
                    double n22 = (double)n2;

                    double result1=n11/n22;
                    Console.Write("{0} / {1} = {2:F2} ", (n11), (n22), result1);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero",n1);
                }

            }
            else
            {
                if (n2 > 0)
                {
                    result = n1 % n2;
                    Console.Write("{0} % {1} = {2} ", n1, n2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }


            }

        }
    }
}
