using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class ProductnumDemo
    {
        static void Main(string[] args)
        {
            int num = 234;
            int product = 1;
            do
            {
                int rem = num % 10;
                product=product*rem;
                num=num/10;

            }while(num>0);
            Console.WriteLine($"product  is {product}");
        }
    }
}
