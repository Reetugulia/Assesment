using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assesment
{
    public class ElectricityBill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of units");
            int unit=Convert.ToInt32(Console.ReadLine());
            double totalbill;
            if(unit<=50)
            {
                totalbill = .50 * unit;
            }
            else if(unit>50&&unit<=150)
               
            {
                totalbill = .50 *50 +(unit-50)*.75;
            }
            else if (unit > 150 && unit <= 250)

            {
                totalbill = .50 * 50 + .75*100+ (unit - 150) * 1.20  ;
            }
            else
            {
                totalbill = .50 * 50 + .75 * 100 + 100* 1.20 +  (unit - 250) * 1.50 ;
            }
            Console.WriteLine($"total bill: {totalbill+totalbill*.2}");

        }
    }
}
