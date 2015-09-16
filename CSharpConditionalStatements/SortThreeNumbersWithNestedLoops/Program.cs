using System;

namespace SortThreeNumbersWithNestedLoops
{
    class SortThreeNumbersWithNestedLoops
    {
        private static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.Write(a + " ");
                    if (b > c) Console.WriteLine(b + " " + c);
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.Write(b + " ");
                    if (b > c) Console.WriteLine(a + " " + c);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }
}