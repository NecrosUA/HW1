using System;
using System.Collections.Generic;
using System.Text;

namespace Area_calc
{
    class Square : Shape
    {
        private double a { get; set; }

        public Square () { } 
        public Square (double A) 
        {
            a = A;
        }
        public override double GetArea()
        {
            return Math.Round(a*a);
        }
    }
}
