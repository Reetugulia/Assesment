using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Krushanmurti
    {
        public static int Fact(int n)
        {
            int fact = 1;

            do
            {
                fact = fact * n;
                n = n - 1;
            } while (n!= 0);
            //  Console.WriteLine(fact);
            return fact;
        }
        public static void checkkrishanmurti(int n)
        {
            int orginial = n;
           
            int sum = 0;
            do
            {
               int rem = n % 10;
                sum = sum + Fact(rem);
               // Console.WriteLine(Fact(rem));
               // Console.WriteLine(sum);
                n = n / 10;

            } while (n!= 0);
            Console.WriteLine(sum);
            if (orginial==sum)
            {
                Console.WriteLine($"{orginial} is krishnamurti");
            }
            else
            {
                Console.WriteLine($"{orginial} is not  krishnamurti");
            }
        }
            static void Main(string[] args)
            {
                Console.WriteLine("enter the number");
                int n = Convert.ToInt32(Console.ReadLine());
                checkkrishanmurti(n);

            }

        }

    }


