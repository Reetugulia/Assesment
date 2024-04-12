using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class factorsDemo
    {
        static void Main(string[] args)
        {
            int num = 24;
            for(int i = 1; i <= num; i++) 
            { 
                if(num % i == 0)
                {
                    Console.WriteLine($"the factors of {num} is {i}");
                }
            }
        }
    }
}
