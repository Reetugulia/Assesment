using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Factorialsum
    {
        public static int Fact(int n) 
        {
            int fact = 1;
           
            do 
            { 
                fact=fact*n;
                n = n - 1;
            }while (n > 0);
          //  Console.WriteLine(fact);
            return fact;
        }
        public static void Sum(int n)
        {
           
            int sum = 0;
            do
            {
                sum=sum+Fact(n);
                // Console.WriteLine(Fact(i));
                n = n - 1;
            } while (n > 0);
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
           int  n = Convert.ToInt32(Console.ReadLine());
            //Fact(n);
            Sum(n);

        }
    }
}
