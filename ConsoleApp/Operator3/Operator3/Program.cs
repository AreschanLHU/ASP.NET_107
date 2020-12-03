using System;

namespace Operator3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 簡化運算應用
            int x = 6, y = 3;
            Console.WriteLine("x: " + x + ", y: " + y + "\nx += y = " + (x += y));
            Console.WriteLine("x -= y = " + (x -= y));
            Console.WriteLine("x *= y = " + (x *= y));
            Console.WriteLine("x /= y = " + (x /= y));
            Console.Read();
        }
    }
}
