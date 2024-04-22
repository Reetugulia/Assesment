using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class CompoundInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount ");
            float prin=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter the rate of interest");
            float rate = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter the time duration");
            int time=Convert.ToInt32(Console.ReadLine());

            double CI=prin*Math.Pow(1+(rate/100),time);

            Console.WriteLine($"the compound interest is {CI}");

        }
    }
}
