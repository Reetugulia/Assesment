using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class SumPrime
    {
        public static bool checkprime(int num)
        { 
            bool status=true;
            if(num==0||num==1)
            { status=false;}
            else
            {
                for(int i=2; i<num; i++) 
                { 
                    if(num%i==0)
                    {  status=false;}
                }
            }
            return status ;

        }
        public static void sum(int[]arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkprime(arr[i]) )
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine($"sum of prime in array is {sum}");
        }
        static void Main(string[] args)
        {
            //int num = 2;
            int[] arr1 = { 2, 4, 3, 5, 7, 9, 10, 11, 12, 13 };
            sum(arr1);
            
        }
    }
}
