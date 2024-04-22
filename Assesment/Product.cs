using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Product
    {
        /* private int code;
         private string name;
         private double price;

         public int Code 
         { 
              set{ code = value; }
             get{ return code; }
         }
         public string Name
         {
             set { name = value; }
             get { return name; }
         }
         public double Price
         {
             set { price = value; }
             get { return price; }
         }*/

        //For auto increment
        //it will create the data members internally and assign the value also retrive the values


        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
