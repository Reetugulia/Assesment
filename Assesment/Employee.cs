using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //parent/base class
    public class Employee
    {
        //declare data members
        protected int id;//4 bytes
        protected string name;//4 bytes
        protected double bs,hra,pf,gross;//32 bytes


        //working with methods
        public Employee() 
        {
            id = 101;
            name = "Reetu";
            bs = 17000;
            hra = 13000;
            pf = 2000;
        }
        //method which accept the value from parameter
        public Employee(int empid, string ename, double b, double h, double p) 
        {
           id= empid;
            name = ename;
            bs = b;
            hra = h;
            pf = p;
        }
        public  virtual void Calculate()
        {
            gross=(bs+hra)-pf;
        }

        public virtual string Display()
        { 
            return $"Employee salary : id:{id}, ename:{name}, salary:{gross}";
        }

    }
}
