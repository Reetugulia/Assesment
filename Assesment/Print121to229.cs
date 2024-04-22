using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Print121to229
    {
        static void Main(string[] args)
        {
            int num=121;
            do
            {

                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    num++;
                }
                else
                    num++;


            } while (num < 229);
        }
    }
}
