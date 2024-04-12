using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class TernaryOperatorDemo
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 5;
            int num3 = 2;

            int maxnum=(num1>num2)?num1:(num2>num3)?num2:num3;
            Console.WriteLine($"the highest number is {maxnum}");
        }
    }
}
