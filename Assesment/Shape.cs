using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    abstract public class Shape
    {
        public abstract void CalculateArea();

        public void Display()
        {
            // define some basic info about Shape
        }

    }
    public class Circle : Shape
    {
        private int radius;
        private double result;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            result = 3.14 * radius * radius;
        }
        public string Print()
        {
            return $"Area of circle is {result}";
        }
    }

    public class Reactangle:Shape
    {
        private int length;
        private int bredth;
        private int result;

        public Reactangle(int length, int bredth) 
        {  
            this.length = length;   
            this.bredth = bredth;
        }
        public override void CalculateArea()
        {
            result = length*bredth;
        }
        public string Print()
        {
            return $"Area of rectangle is {result}";
        }
    }


}
