using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PercentageDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter english marks");
            double m1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter maths marks");
            double m2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter java marks");
            double m3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter DotNet marks");
            double m4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter  angular marks");
            double m5 = Convert.ToDouble(Console.ReadLine());

            double total = m1 + m2 + m3 + m4 + m5;
            double avg = total / 5;

            Console.WriteLine($"total is {total}");
            Console.WriteLine($"average is {avg} ");

            double percentage = ((total) * 100) / 500;
            Console.WriteLine($"percentage is {percentage}");

            

        }
    }
}
