using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHours = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var studentHours = int.Parse(Console.ReadLine());
            var studentMinutes = int.Parse(Console.ReadLine());

            var examTime = examHours * 60 + examMinutes;
            var studentTime = studentHours * 60 + studentMinutes;
            var minutesOfDiferences = studentTime-examTime;

            if (minutesOfDiferences<-30)
            {
                Console.WriteLine("Early");
            }
            else if (minutesOfDiferences<=0)
            {
                Console.WriteLine("On Time");
            }
            else
            {
                Console.WriteLine("Late!");
            }


            if (minutesOfDiferences !=0)
            {
                var hours = Math.Abs(minutesOfDiferences / 60);
                var minutes = Math.Abs(minutesOfDiferences % 60);
                if (hours>0)
                {
                    if (minutes<10)
                    {
                        Console.Write(hours + ":0" + minutes +" hours");
                    }
                    else
                    {
                        Console.Write(hours + ":" + minutes + "hours" );
                    }

                }
                else
                {
                    Console.Write(minutes+ "minutes");
                }
                if (minutesOfDiferences<0)
                {
                    Console.WriteLine("before the start");
                }
                else
                {
                    Console.WriteLine("after the start");
                }
            }





        }
    }
}
