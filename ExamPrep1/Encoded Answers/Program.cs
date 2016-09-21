using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string result = null;
            var a=0;
            var b=0;
            var c=0;
            var d = 0;
            for (int i = 1; i <= n; i++)
            {
                
                uint num = uint.Parse(Console.ReadLine());
                string answer;
                if (num % 4 ==0)
                {
                    answer = "a";
                    a++;
                }
                else if (num %4==1)
                {
                    answer = "b";
                    b++;
                }
                else if (num % 4 ==2)
                {
                    answer = "c";
                    c++;
                }
                else 
                {
                    answer = "d";
                    d++;
                }
                result =result + answer + ' ';
                
               
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0} ",a);
            Console.WriteLine("Answer B: {0} ",b);
            Console.WriteLine("Answer C: {0} ",c);
            Console.WriteLine("Answer D: {0} ",d);

        }
    }
}
