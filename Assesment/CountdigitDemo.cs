using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class CountdigitDemo
    {
        static void Main(string[] args)
        {
            int num = 23456;
            int count = 0;
            do
            {
                count++;
                num=num/10;

            } while (num!=0);
            Console.WriteLine(count);

        }
    }
}
