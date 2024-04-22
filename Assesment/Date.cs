using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Date
    {
        private int day,month,year;

        public Date()
        {
            day = 20;
            month = 01;      
            year = 2024;
        }
        public Date(int d,int m,int y)
        {
            day=d;
            month=m;
            year=y;
        }

        public string Display() 
        { 
            return $"date is ={day}:{month}:{year}";
        }
    }
}
