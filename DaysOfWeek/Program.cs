using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
};
            for (int i = 0; i < day.Length; i++)
                break;
            {
                int dayNum = int.Parse(Console.ReadLine());
                if (dayNum >=1 && dayNum <= 7) { 
                Console.WriteLine(day[dayNum - 1]);
            }
                else
                {
                    Console.WriteLine("Invalid day");
                }
            }
        }
    }
}
