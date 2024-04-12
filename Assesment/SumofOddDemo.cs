using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SumofOddDemo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"sum of odd number from 1 to 20 is {sum}");
        }
    }
}
