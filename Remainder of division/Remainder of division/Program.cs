using System;
using System.Diagnostics;

namespace Remainder_of_division
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            
            double start, end;
            

            Console.WriteLine("Insert start range please:");
            start = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insert end range please:");
            end = Convert.ToDouble(Console.ReadLine());

            double i = start;

            Console.WriteLine("Remainder of division 1.0 by Kokhanchuk Rostyslav");
            sw.Start();
            do
            {
                if (i % 2 != 0 | i == 2) Console.WriteLine(i);
                i++;
            }
            while (i<=end);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
