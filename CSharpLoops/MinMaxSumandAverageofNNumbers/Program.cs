using System;

namespace MinMaxSumandAverageofNNumbers
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());

            double min = double.MaxValue;
            double max = double.MinValue;

            double sum = 0;

            for (int i = 0; i < number; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a < min)
                {
                    min = a;
                }
                if (a > max)
                {
                    max = a;
                }
                sum = sum + a;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            Console.WriteLine(sum/number);
        }
    }
}