using System;
using System.Collections.Generic;
using System.Text;

namespace Area_calc
{
    class Circle : Shape
    {
        private double r { get; set; }

        public Circle() { } //default constructor in case if we transfer nothing
        public Circle(double R) //Overrided Constructor for radius of circle
        {
            r = R;
        }


        public override double GetArea()
        {
            return Math.Round(Math.PI * (r * r),4);
        }
    }
}
