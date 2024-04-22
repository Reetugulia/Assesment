using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Palindrome
    {
        public static void checkpalindrome(int n)
        {
            int original = n;
            int rev = 0;
            int rem = 0;
            do 
            {
                rem = n % 10;
                rev=rev*10+rem;
                n=n/10;
            }   while (n>0);
            if(original==rev)
            {
                Console.WriteLine($"{original} number is palindrome");
            }
            else 
            {
                Console.WriteLine($"{original} number is not palindrome");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            checkpalindrome (n);
        }
    }
}
