using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class CircleAreaDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius");
            double radius=Convert.ToDouble(Console.ReadLine());
            double area =  3.14 * radius*radius;
            Console.WriteLine($"the area of circle with radius {radius} is {area}");
        }
    }
}
