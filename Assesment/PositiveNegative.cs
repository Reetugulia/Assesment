using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int num=Convert.ToInt32(Console.ReadLine());

            String number = (num > 0) ? "positive number" : (num == 0) ? "number is zero " : "number is negative";

            Console.WriteLine($"{number}");
        }
    }
}
