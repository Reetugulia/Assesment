using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Divisibleby5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%5 == 0 && num%11==0) 
            {
                Console.WriteLine($"number :{num} is divisible by both 11 and 5");
            }
            else
            {
                Console.WriteLine($"number :{num} is not divisible by both 11 and 5");
            }
        }
    }
}
