using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if(year %400==0)
                    {
                        Console.WriteLine($"{year} is a leap year");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is not a leap year");
                    }


                } 
            }
            else 
            { Console.WriteLine($"{year} is not a leap year"); }
        }
    }
}
