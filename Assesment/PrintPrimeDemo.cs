using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class PrintPrimeDemo
    {
        public static Boolean checkprime(int n)
        {
            bool result = true;
            if(n==0||n==1) 
            {
                result = false;
            }
            else 
            { 
                for(int i = 2; i < n; i++) 
                { 
                    if(n%i==0)
                    { result = false; }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            for (int i = 400; i >=300; i--) 
            {
                if (checkprime(i))
                {
                    Console.WriteLine(i);
                }
            }
            

            
        }
    }
}
