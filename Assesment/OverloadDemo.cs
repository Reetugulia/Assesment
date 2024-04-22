using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assesment
{
    public class OverloadDemo
    {
        private int radius;
        private int length;
        private int bredth;
        private double height;
        private double base1;

        public OverloadDemo()
        {

        }
        public  double  Calculatearea(double base1,double height)
        {
            return .2 * base1 * height;
        }
        public  double Calculatearea(int radius) 
        { 
            return 3.14*radius*radius;
        }
        public  double Calculatearea(int length,int bredth)
        {
            return length*bredth;
        }
       


        static void Main(string[] args) 
        {
            OverloadDemo demo = new OverloadDemo();
            

            Console.WriteLine("enter your option");
            Console.WriteLine("1.area of circle");
            Console.WriteLine("2.Area of rectangle");
            Console.WriteLine("3.Area of triangle");

            int option=Convert.ToInt32(Console.ReadLine());
            switch(option) 
            {
                case 1:Console.WriteLine("enter radius");
                       int radius=Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine(demo.Calculatearea(radius));
                        break;

                case 2:Console.WriteLine("enter length");
                       int len=Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine("enter bredth");
                       int breadth=Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine(demo.Calculatearea(len, breadth));
                        break;
                case 3:
                       Console.WriteLine("enter base");
                       double b = Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine("enter height");
                       double h = Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine(demo.Calculatearea(b, h));
                       break;
                default: Console.WriteLine("choose correct option");
                         break;

            }
        }


    }
}
