using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Shopping
    {
        private int productid;
        private string productname;
        private int price;
        private int quantity;
        double totalbill;

        public void Accept(int id,string name,int p,int q) 
        {
            productid=id;
            productname=name; 
            price=p;
            quantity=q;
        }
        public void Calculate()
        { 
           
                totalbill= quantity*price;
           

        }
        public string Show() 
        {
            if (quantity >= 0)
            { return $"product id: {productid} ,product name: {productname} , totalbill: {totalbill}"; }
            else
                return "error";
           
        }
    }
}
