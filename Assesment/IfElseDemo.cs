using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assesment
{
    public class IfElseDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            if (age > 18) {
                Console.WriteLine("eligible for vote");
            
            }
            else
            {
                Console.WriteLine("not eligible for vote");
            }
        }

    }
}
