using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Displaynumber1to50
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 50; i++) 
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine($"welcome to pune=>{i}");
                }

                else if (i %3== 0)
                {
                    Console.WriteLine($"pune =>{i}");
                }
                else if(i %5== 0) 
                {
                    Console.WriteLine($"welcome=> {i}");
                }
              
               
            }
        }
    }
}
