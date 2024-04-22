using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public interface ICustomer
    {
        string Print();
    }
    public interface IOrder
    {
        string Print();
    }

    public class Transaction : ICustomer, IOrder
    {
        //it is by default public
        string ICustomer.Print()
        {
            return "customer details";
        }

        string IOrder.Print()
        {
            return "order details";
        }
    }

}
