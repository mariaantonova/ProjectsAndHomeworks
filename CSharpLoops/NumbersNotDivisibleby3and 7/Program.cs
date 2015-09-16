using System;

namespace NumbersNotDivisibleby3and_7
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                if ((i%3 == 0) || (i%7 == 0))

                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}