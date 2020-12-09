using System;

namespace ArrSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string vconsole = "";
            int length;

            Console.WriteLine("Sorting Array 2.3 by Kokhanchuk Rostyslav");


                if (args.Length > 0)
                {
                    int[] nums = new int[args.Length];

                    for (int i = 0; i < args.Length; i++)
                    {
                        nums[i] = Convert.ToInt32(args[i]);
                    }
                    SumMinMaxAvgDevSort(nums);
                }
                else
                {
                    while (vconsole.ToLower() != "exit")
                    {
                        Console.WriteLine("Insert length of array please: ");
                        vconsole = Console.ReadLine();

                        if (!int.TryParse(vconsole, out length))
                        {
                            if (vconsole.ToLower() != "exit")
                            {
                                Console.WriteLine("Insert correct number please! ");
                            }
                        }

                        int[] nums = new int[length]; //create double array with specified length

                        for (int i = 0; i < length; i++)
                        {
                            Console.WriteLine("Insert number:");
                            vconsole = Console.ReadLine();
                            nums[i] = Convert.ToInt32(vconsole);
                        }

                        SumMinMaxAvgDevSort(nums);
                    }
            }



        }

        public static void SumMinMaxAvgDevSort(int[] numbers)
        {
            double sum = 0;

            double M = 0.0;
            double S = 0.0;
            int k = 1;
            int i = 0;

            while(i<numbers.Length) 
            {
                sum += numbers[i]; //calc sum

                double tmpM = M; //calculating deviation
                M += (numbers[i] - tmpM) / k;
                S += (numbers[i]  - tmpM) * (numbers[i]  - M);
                k++;
                i++;
            }

            for (i = numbers.Length-1; i > 0; i--) //buble sorting + min max
            { 
                for(int j = 0 ; j < i ; j++)
                { 
                    if( numbers[j] > numbers[j+1] ) 
                    { 
                        int tmp = numbers[j];  
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Sorted array:");
            Array.ForEach(numbers,Console.WriteLine);
            Console.WriteLine("\n");
            
            Console.WriteLine($"Deviation is: {Math.Round(Math.Sqrt(S / (k - 1)), 2)}");
            Console.WriteLine($"Average is: {Math.Round(sum / numbers.Length,2)}");
            Console.WriteLine($"Minimum is: {numbers[0]}");
            Console.WriteLine($"Maximum is: {numbers[numbers.Length-1]}");
            Console.WriteLine($"Sum is: {sum}");

        }
    }
}
