using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontime
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var h_arrive = int.Parse(Console.ReadLine());
            var m_arrive = int.Parse(Console.ReadLine());
            if((hour <=23 && h_arrive <= 23) && (m<=59 & m_arrive<=59)){
            
            
                if (hour == h_arrive & m == m_arrive)
                {
                Console.WriteLine("On time");
                }
                if(hour<h_arrive & m<m_arrive)
                {
                Console.WriteLine("Late{0}:{1} hours after the start",(h_arrive-hour),(m_arrive-m));
                }
                if (hour < h_arrive & m > m_arrive) 
                {
                 Console.WriteLine("Late{0} hours :{1} minutes after the start", (h_arrive - hour), (m - m_arrive));
                }
                if (hour > h_arrive & m < m_arrive) 
                {
                    Console.WriteLine("Early{0} hours :{1} minutes after the start", (hour-h_arrive), (m_arrive - m));
                }
                if (hour > h_arrive & m > m_arrive)
                {
                    Console.WriteLine("Early{0} hours :{1} minutes after the start", (hour - h_arrive), (m-m_arrive));
                }
                
         }
        }
    }
}
