using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2=Convert.ToInt32(Console.ReadLine());

            int num3=num1+ num2;

            Console.WriteLine($"addition of {num1} and {num2} is {num3}");
        }

    }
}
