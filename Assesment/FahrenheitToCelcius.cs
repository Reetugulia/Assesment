using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class FahrenheitToCelcius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature in fahrenheit");
            float tem = Convert.ToSingle(Console.ReadLine());

            float celci = ((tem - 32) *5 )/ 9;

            Console.WriteLine($"the temperature in fahrenheight is {celci}");
        }
    }
}
