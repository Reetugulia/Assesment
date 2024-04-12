using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PercentageGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter java marks");
            double m1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter python marks");
            double m2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter angular marks");
            double m3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter javascript marks");
            double m4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter ty marks");
            double m5 = Convert.ToDouble(Console.ReadLine());

            double per = (m1 + m2 + m3 + m4 + m5) * 100 / 500;

            if(per <=100&&per>90)
            {
                Console.WriteLine($"you have got grade A with {per} ");
            }

            else if (per <= 90 && per > 80)
            { 
                Console.WriteLine($"you have got grade B  with {per} ");
            }

            else if (per <= 80 && per > 60)
            {
                Console.WriteLine($"you have got grade C with {per} ");
            }

            else if (per <= 60 && per > 40)
            {
                Console.WriteLine($"you have got grade D with {per} "); 
            }

            else
            {
                Console.WriteLine("YOU HAVE FAILED ");
                //grading
                    }


        }
    }
}
