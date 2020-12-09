using System;

namespace Math_margin
{
    class Program
    {
        static void Main(string[] args)
        {
            //double p1Rate, p2Rate, drawRate;

            Console.WriteLine("Margin cal 0.1 by Kokhanchuk Rostyslav:");

            Console.Write("Please insert name of 1st player: ");
            var player1  = Console.ReadLine();

            Console.Write("Please insert name of 2nd player: ");
            var player2  = Console.ReadLine();

            Console.Write("Please insert win rate p1: ");
            var p1  = Console.ReadLine();

            Console.Write("Please insert win rate p2: ");
            var p2  = Console.ReadLine();

            Console.Write("Please insert draw rate x: ");
            var x  = Console.ReadLine();

            Console.WriteLine("\n");

            var p1Rate = 100 / Convert.ToDouble(p1);
            Console.WriteLine($"Win rate of player {player1} is: {Math.Round(p1Rate,2)}%");

            var p2Rate = 100 / Convert.ToDouble(p2);
            Console.WriteLine($"Win rate of player {player2} is: {Math.Round(p2Rate,2)}%");

            var drawRate = 100 / Convert.ToDouble(x);
            Console.WriteLine($"Draw rate is: {Math.Round(drawRate,2)}%");

            double tax = (Convert.ToDouble(p1Rate) + Convert.ToDouble(p2Rate) + Convert.ToDouble(drawRate)) - 100;
            Console.WriteLine($"Tax is: {Math.Round(tax,2)}%");


        }
    }
}
