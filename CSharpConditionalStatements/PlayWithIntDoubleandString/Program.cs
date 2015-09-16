using System;

namespace PlayWithIntDoubleandString
{
    class PlayWithIntDoubleandString
    {
        static void Main()
        {
            Console.WriteLine("0 for int, 1 for double, 2 for string!");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 0: int b = int.Parse(Console.ReadLine()); Console.WriteLine(b+1); break;
                case 1: double c = double.Parse(Console.ReadLine()); Console.WriteLine(c + 1.00); break;
                case 2: string d = Console.ReadLine(); Console.WriteLine(d + "*"); break;
                default: Console.WriteLine("INCORECT INPUT DETAILS"); break;
            }
        }
    }
}