using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SwapDemo
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;
            Console.WriteLine($"the first number before swapping is {num1} and second is {num2}");
            int temp = num1;
            num1= num2;
            num2= num1;
            Console.WriteLine($"the first number after swapping is {num1} and second is {num2}");

        }
    }
}
