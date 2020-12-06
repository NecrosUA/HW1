using System;

namespace EDU
{
    class Program
    {

            static void Main(string[] args)
            {
                int  b = 1983, c = 3, d = 20;
                

                Console.WriteLine("Expression calc 0.1 by Kokhanchuk Rostyslav:");
                Console.WriteLine("y=(((e^a+4*lg(c))/sqrt(b))*|arctg(d)|+5/sin(a)");
                Console.WriteLine("'b' - year of birth of developer");
                Console.WriteLine("'c' - month of birth of developer");
                Console.WriteLine("'d' - day of birth of developer");
                Console.WriteLine("'a' - inserting by user");
                Console.WriteLine("\n");

                Console.Write("Input a please: ");

                var a  = Console.ReadLine();

                var y = (Math.Pow(Math.E,Convert.ToDouble(a)) + 4 * Math.Log(c))/Math.Sqrt(b) //((e^a+4*lg(c))/sqrt(b))
                * Math.Abs(Math.Atan(d)) + 5/Math.Sin(Convert.ToDouble(a)); //*|arctg(d)|+5/sin(a)

                Console.WriteLine($"Y = {y} ");
            }
    }
}
