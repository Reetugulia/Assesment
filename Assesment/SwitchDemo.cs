using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SwitchDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int num=Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                 case 0:
                  Console.WriteLine("zero");
                    break;
                 case 1:
                    Console.WriteLine("one");
                 break;
                 case 2:
                    Console.WriteLine("two");
                    break;
                 case 3:
                    Console.WriteLine("three");
                    break;
                 default:
                    Console.WriteLine("number not present");            
                    break;
            }

        }
    }
}
