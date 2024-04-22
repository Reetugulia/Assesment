using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PrintAlphabets
    {
        static void Main(string[] args)
        {
            for (int i = 97;i<=122;i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
