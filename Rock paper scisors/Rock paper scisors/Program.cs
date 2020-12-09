using System;
using System.Collections.Generic;

namespace Rock_paper_scisors
{
    class Program
    {
        static void Main(string[] args)
        {
            string console = "";
            string result = "";
            int select;
            string[] game = new string[] { "rock", "paper", "scisors" };
            List<HistoryType> statistic = new List<HistoryType>();

            //statistic.Add(new HistoryType { compSel = "scisors"});

            Random random = new Random();

            Console.WriteLine("Rock papers scisors 0.1 by Kokhanchuk Rostyslav");

            while (console.ToLower() != "exit")
            {
                Console.WriteLine("Please type your item: rock, paper, scisors or type exit to stop game ");
                console = Console.ReadLine();

                select = random.Next(0,3);

                switch (select) 
                {
                    case 0: //if computer selected rock
                        switch (console.ToLower())
                        {
                            case "rock":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "Draw";
                                break;
                            case "paper":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "You won";
                                break;
                            case "scisors":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "You failed";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 1: //if computer selected paper
                        switch (console.ToLower())
                        {
                            case "rock":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "You failed";
                                break;
                            case "paper":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "Draw";
                                break;
                            case "scisors":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "You won";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2: //if computer selected scisors
                        switch (console.ToLower())
                        {
                            case "rock":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "You won";
                                break;
                            case "paper":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "You failed";
                                break;
                            case "scisors":
                                Console.WriteLine($"You selected {console.ToLower()}");
                                result = "Draw";
                                break;
                            default:
                                break;
                        }
                        break;
                }

                if (console.ToLower() == "rock" || console.ToLower() ==  "paper" || console.ToLower() ==  "scisors")
                { 
                    Console.WriteLine($"Computer selected {game[select]}");
                    Console.WriteLine(result);
                    statistic.Add(new HistoryType { compSel = game[select], usrSel = console.ToLower(), result = result }); 
                }
                

            }
            int i = 0;
            Console.WriteLine("Statistic:");

            foreach (var item in statistic)
            {
                Console.WriteLine($"{++i} Computer:{item.compSel} You:{item.usrSel} Result:{item.result}");
            }
        }
    }
}
