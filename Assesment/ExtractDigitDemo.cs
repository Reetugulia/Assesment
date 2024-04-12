using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class ExtractDigitDemo
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int rem = 0;
            do
            {
                rem = num % 10;
                Console.WriteLine($"digits are{rem}");
                num = num / 10;
                
            }while (num != 0);
            

        }
    }
}
