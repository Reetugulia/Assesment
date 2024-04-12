using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int num=Convert.ToInt32(Console.ReadLine());

            if(num %2== 0) {
                Console.WriteLine($"{num} is even");
            }
            else 
            { Console.WriteLine($"{num} is odd"); }
        }
    }
}
