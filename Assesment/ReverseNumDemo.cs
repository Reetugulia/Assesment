using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class ReverseNumDemo
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int rem = 0;
            int revnum=0;
            do
            {
                rem = num % 10;
                revnum = revnum*10+rem;
                num=num/10;


            } while (num != 0);
            Console.WriteLine($"reverse of number is{revnum}");
        }
    }
}
