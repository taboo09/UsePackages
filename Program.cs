using System;
using FizzBuzzPackage;

namespace UsePackages
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResults();
        }

        public static void DisplayResults()
        {
            const int LINE = 3;
            int[] arr = new int[] { 1, 4, 11, 33, 6, 9, 12, 21, 33, 25, -5, 5, 10, 55, 100, 15 };

            var index = 0;
            var occurrence = 0;

            do
            {
                if (occurrence == LINE) 
                {
                    occurrence = 0;
                    Console.WriteLine();
                }

                var result = FizzBuzz.GetResult(arr[index]);

                if (result == "FizzBuzz") 
                {
                    Console.WriteLine(" !!! FizzBuzz !!! ");

                    return;
                }

                occurrence++;
                Console.Write($"{result}   ");

                index++;

            } while (arr.Length > index);
        }
    }
}
