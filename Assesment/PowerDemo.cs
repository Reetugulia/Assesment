using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PowerDemo
    {
        static void Main(string[] args)
        {
            int num = 2;
            int pow = 3;
            int power = 1;
            for (int i = 0; i < pow; i++)
            {
                power = power * num;
            }
            Console.WriteLine($"{num} power {pow} is {power}");

        }
    }
}
