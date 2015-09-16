using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        if (min <= max)
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write(random.Next(min, max + 1) + " ");
            }

            Console.WriteLine();
        }
    }
}