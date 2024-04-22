using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Searchelement
    {
        public static void search(int[] arr1, int num)
        { 
            for(int i = 0; i < arr1.Length; i++) 
            {
                if (arr1[i] == num)
                {
                   
                }

            }
            Console.WriteLine($"{num} is present in array ");
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 4, 3, 5, 7, 9, 10, 11, 12, 13 };
            Console.WriteLine("enter the number you want to search");
            int num = Convert.ToInt32(Console.ReadLine());
            search(arr1 , num);
        }
    }
}
