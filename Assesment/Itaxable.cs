using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public interface Itaxable
    {
        double PayTax();//public,abstract,virtual
    }
    //implicit implement of interface

    public class Job:Itaxable 
    {
        private double salary;
        private double taxamount;

       public Job()
        {
            salary = 10000;
        }

        public double PayTax()
        {
            taxamount = salary * .2;
            return taxamount;
        }
    }
    public class Business : Itaxable
    {
        private double salary;
        private double taxamount;
        public Business()
        {
            salary = 10000;
        }
        public double PayTax()
        {
            taxamount = salary * .3;
            return taxamount;
        }
    }
}
