using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assesment
{
    public class StudentDemo
    {
        private int id;
        private string name;
        private double marks1,marks2,marks3,percentage;

        public  void Accept(int id, string name, double marks1, double marks2, double marks3)
        {
            this.id = id;
            this.name = name;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;

        }
        public void Calculate()
        {
             percentage = ((marks1+marks2+marks3)*100)/300;
        }

        public string Display()
        { 

            return $"student id{id}, name:{name},percentage:{percentage}";
        }

    }
    
}
