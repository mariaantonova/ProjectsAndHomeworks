using System;

namespace Numbersfrom1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
