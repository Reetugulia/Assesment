using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class MergeDemo
    {
        public static void Mergarray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length+arr2.Length];
            int index = 0;
            for (int i = 0; i < arr1.Length; i++) 
            {
                arr3[index] = arr1[i];
                index++;
                //Console.Write(arr3);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[index] = arr2[i];
                index++;

               // Console.Write(arr3);
            }
            for(int i = 0;i < arr3.Length; i++)
            {
                Console.Write(arr3[i]+" ");
            }
            // Console.Write(arr3);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 8, 9 };
            Mergarray(arr1, arr2);
        }
    }
}
