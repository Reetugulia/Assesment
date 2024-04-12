using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class AreaTriangleDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base ");
            double b=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the height ");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = .5 * b * h;
            Console.WriteLine($"The area of triangle with base{b} and height {h} is {area}");


        }
    }
}
