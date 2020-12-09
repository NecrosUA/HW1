using System;

namespace EDU
{
    class Program
    {

            static void Main(string[] args)
            {
                int  b = 2001, c = 3, d = 30;
                

                Console.WriteLine("Expression calc 0.1 by Kokhanchuk Rostyslav:");
                Console.WriteLine("y=(((e^a+4*lg(c))/sqrt(b))*|arctg(d)|+5/sin(a)");
                Console.WriteLine("'b' - year of birth of developer");
                Console.WriteLine("'c' - month of birth of developer");
                Console.WriteLine("'d' - day of birth of developer");
                Console.WriteLine("'a' - inserting by user");
                Console.WriteLine("\n");

                Console.Write("Input a please: ");

                var a  = Convert.ToDouble(Console.ReadLine());

                var y = Math.Round(((Math.Pow(Math.E,a) + (4 * Math.Log10(c)))/Math.Sqrt(b)) //((e^a+4*lg(c))/sqrt(b))
                * Math.Abs(Math.Atan(d)) + (5/Math.Sin(a)),4); //*|arctg(d)|+5/sin(a)

                Console.WriteLine($"Y = {y} ");
            }
    }
}
