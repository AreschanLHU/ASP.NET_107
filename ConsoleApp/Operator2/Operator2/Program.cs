using System;

namespace Operator2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 遞增與遞減運算子
            int x = 0, y = 1;
            x = ++y;
            Console.WriteLine("x = " + x + ", y = " + y);
            // y=2
            y++;
            Console.WriteLine("x = " + x + ", y = " + y);
            // y=3
            x = y--;
            Console.WriteLine("x = " + x + ", y = " + y);
            Console.Read();
        }
    }
}
