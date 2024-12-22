
using System;

namespace  OddEvenNumber
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] numbes = { 1, 2, 3, 4, 5, 6, 76};

            PrintNumbers("Numbers :", numbes);
            PrintNumbers("Odd Num :", numbes.Where(x => IsOdd(x)));
            PrintNumbers("Even Num :", numbes.Where(x => IsEven(x)));

            Console.WriteLine();
            
        }

        static void PrintNumbers(string title, IEnumerable<int > numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");

            foreach (var n in numbers)
            {
                Console.Write($" {n}");
            }

            Console.Write($" ]");

            Console.WriteLine();
                
        }

        static bool IsEven(int number) => number % 2 == 0;


        static bool IsOdd(int number) => !IsEven(number);
        
    }

}
