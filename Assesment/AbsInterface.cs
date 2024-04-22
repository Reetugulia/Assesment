using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
     public abstract class AbsInterface
     {
         public int num1=30;
        public abstract int addition();
     }
     interface ICalculate
    {
        int Num2 { get; set; }
        public int addition();
    }
    class Add : AbsInterface,ICalculate
    {
        public int Num2 { get; set; }
        // public int result;
        public Add()
        {
            Num2 = 20;
            
        }
      
        public override int addition()
        {
            return num1 + Num2;
        }
    }
  
}

   


