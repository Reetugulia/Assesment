using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public  class EquilateralArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of side");
            int side=Convert.ToInt32(Console.ReadLine());

            double area=.432*side*side;
            Console.WriteLine($"the area of equilatateral triangle with {side} is {area}");
        }
    }
}
