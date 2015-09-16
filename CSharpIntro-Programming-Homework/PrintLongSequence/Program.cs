using System;

class PrintLongSequence
{
    private static void Main(string[] args)
    {
        int a = 2;
        int b = 0;

        for (int i = 0; i < 1000; i++)
        {
            if (b == 0)
            {
                //...
            }
            else
            {
                Console.Write("-");
            }

            Console.WriteLine(a);

            a++;

            if (b == 0)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }
        }
    }
}