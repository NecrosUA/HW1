using System;
using System.Collections.Generic;
using System.Text;

namespace Area_calc
{
    class Triangle : Shape
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        private double p = 0;

        public Triangle() { }

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public override double GetArea()
        {
            p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
