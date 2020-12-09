using System;
using System.Collections.Generic;
using System.Text;

namespace Area_calc
{
    class Rectangle : Shape
    {
        private double a { get; set; }
        private double b { get; set; }

        public Rectangle() { }
        public Rectangle(double A, double B)
        {
            a = A; 
            b = B;
        }
        public override double GetArea()
        {
            return Math.Round(a * b);
        }
    }
}
