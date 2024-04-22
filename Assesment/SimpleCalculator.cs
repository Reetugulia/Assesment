using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SimpleCalculator
    {
       static void Main(string[] args)
        {
            Console.WriteLine("enter first number ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("choose your the option");
            Console.WriteLine("1.Add two numbers");
            Console.WriteLine("2.Subtract two numbers");
            Console.WriteLine("3.Divide two numbers");
            Console.WriteLine("4.Multiply numbers");
            int Options=Convert.ToInt32(Console.ReadLine());

            switch(Options) 
            {
                case 1: Console.WriteLine($"{num1 + num2}");
                        break;

                case 2: Console.WriteLine($"{num1 - num2}");
                       break;
                case 3: Console.WriteLine($"{num1 / num2}");
                       break;
                case 4: Console.WriteLine($"{num1 * num2}");
                        break;
                default: Console.WriteLine("choose the correct option");
                        break;
            }
        }
    }
}
