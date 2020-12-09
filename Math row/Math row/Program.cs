using System;

namespace Math_row
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math row 0.1 by Kokhanchuk Rostyslav");

            double bdate = 1983;
            double i = 1;
            double result = 0,sum = 0;

            do
            {
                result = 1 / (i * (i + 1));
                sum += result;
                i++;
                Console.WriteLine(result);
            }
            while (result >= 1 / bdate);
            Console.WriteLine($"Done! Summ is: {sum}");
        }
    }
}
