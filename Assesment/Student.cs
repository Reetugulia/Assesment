using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Student
    {
        private int rollno;
        private string name;
        private static int count;
        //constructor which assign default value to members
        public Student()
        {
            count++;
            rollno = count;
            name = "isha";
                
        }
        //constructor with parameters   
        public Student(string name)
        {
            count++;
            this.rollno = count;   //this refers to data members
            this.name = name;
        }

        public string Display() 
        {
            return $" ROLL no={rollno}, name= {name}";
        }
    }
}
