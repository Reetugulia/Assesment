using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    //in java we use extends keyword here we use : for inheritance
    //base keyword will call the base call constructor
   
    public class Manager:Employee
    {
        private double food;

        public Manager() :base()
        { }

        public Manager(int empid, string ename, double b, double h, double p,double food)
            :base(empid, ename,b,h,p)
        { 
            this.food = food;
        }
        //calculate salary for Manager
        public override void Calculate()
        {
            gross = (bs + hra+food) - pf;
        }

        public override string Display()
        {
            return $"Manager salary : id:{id}, ename:{name}, salary:{gross}";
        }
    }
    
}
