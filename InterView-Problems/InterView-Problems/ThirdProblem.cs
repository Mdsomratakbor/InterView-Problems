using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView_Problems
{
    public static class ThirdProblem
    {
        public static void ClockDegree()
        {
            int hours, minutes;
            Console.Write("Please enter time like this format {Hours Minutes}: ");
            var time = Console.ReadLine().Split(' ');
      
                hours = Convert.ToInt32(time[0]);
                minutes = Convert.ToInt32(time[1]);
            
           
           
            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegress = minutes * 6;
            double difference = Math.Abs(hourInDegrees  - minuteInDegress);
            if (difference > 180)
            {
                difference = 360 - difference;
            }
            Console.WriteLine($"{ difference }");

            Console.ReadKey();
        }
    }
}
