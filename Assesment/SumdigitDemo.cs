using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SumdigitDemo
    {
        static void Main(string[] args)
        {
            int num = 234;
            int sum = 0;
            do
            {
                int rem=num%10;
                sum += rem;

                num /= 10;

            }while(num > 0);
            Console.WriteLine($"sum is {sum}");
        }
    }
}
