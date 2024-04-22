using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //file used by programmer 1
    public partial class Calcu
    {
        /* public int sub(int x,int y)
         { return x - y; }*/
        public void sub(int x, int y)
        {
            int result = x - y;
            Print(result);
        }
        public void Mult(int x, int y)
        {
            int result = x *y;
            Print(result);
        }
        partial void Print(int c)
        {
            Console.WriteLine($" Result=>{c}");
           
        }

    }
}
