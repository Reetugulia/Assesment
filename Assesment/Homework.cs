using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assesment
{
   // IsEmptyOrNull(),Concat,CharAt,ToCharArray,ToUpper,ToLower,IndexOf,LastIndexOf,Substring(),Contains,Split,Trim

    public class Homework
    {
        static void Main(string[] args)
        {
            string str = "hello World hello dot net";
            Console.WriteLine("----------split-----------");
            string[]st=str.Split(',');
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            string str2 = null;
            if(string.IsNullOrEmpty(str)) 
            {
                Console.WriteLine("string  is null or empty");
            }
            else
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("----------Concat-----------");

            str2=string.Concat("language");
            Console.WriteLine(str2);//if the string is null then it concat in that

            foreach (string s in st) 
            { 
                Console.WriteLine(s);
            }
            Console.WriteLine("----------ToChar-----------");
            char [] ch=str.ToCharArray();
            foreach (var s in ch)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------ToUpper-----------");
            
            Console.WriteLine(str.ToUpper());

            Console.WriteLine("----------Tolower-----------");

            Console.WriteLine(str.ToLower());

            Console.WriteLine("----------index-----------");//give index

            Console.WriteLine(str.IndexOf("h"));

            Console.WriteLine("----------Lastindex-----------");//give  last index

            Console.WriteLine(str.LastIndexOf("h"));


            Console.WriteLine("----------substring-----------");//substring

            Console.WriteLine(str.Substring(1,3));

            Console.WriteLine("----------contains-----------");//contain a paricular string

            Console.WriteLine(str.Contains('e'));//give boolean value

            Console.WriteLine("----------trim-----------");//remove space or character

            Console.WriteLine(str.Trim('h'));

            /*Homework

           Remove();
            Replace();
            Clear
            Capacity
            Length*/

            StringBuilder sb = new StringBuilder();
            sb.Append("india ");
            sb.Append("australia");
            Console.WriteLine(sb);
            Console.WriteLine("------------------------");
            sb.Remove(1, 2);//1 is index and 2 no of character removed
            Console.WriteLine(sb);//remove character

            Console.WriteLine("---------Replace--------------");
            sb.Replace('i', 'v');//replace old char with new
            Console.WriteLine(sb);

            sb.Replace('i', 'e', 1, 5);
            Console.WriteLine(sb);
            StringBuilder sb1= new StringBuilder();
            Console.WriteLine("---------capacity--------------");
            Console.WriteLine(sb1.Capacity);//max capacity of charchater allocater=16

            Console.WriteLine("---------length--------------");
            Console.WriteLine(sb1.Length);//length of current string object=0//it will change according to number of char added























        }
    }
}
