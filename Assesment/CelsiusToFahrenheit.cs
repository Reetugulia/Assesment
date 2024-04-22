using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature in celsius");
            float tem=Convert.ToSingle(Console.ReadLine());

            float fah=((9/5)*tem)+32;

            Console.WriteLine($"the temperature in fahrenheight is {fah}");
        }

    }
}
