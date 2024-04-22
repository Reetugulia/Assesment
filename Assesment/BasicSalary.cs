using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assesment
{
    public class BasicSalary
    {
        static void Main(string[] args)
       {
            double grosssalary;
            Console.WriteLine("enter the salary");
            double salary=Convert.ToDouble(Console.ReadLine());
            if (salary <=10000) 
            {
                grosssalary = salary * .25 + salary * .8;
            }
            else if (salary>10000 && salary<=20000 )
            {
                grosssalary = salary * .25 + salary * .9;
            }
            else
            {
                grosssalary = salary * .30 + salary * .95;
            }
            Console.WriteLine(grosssalary);

            
        }
    }
}
