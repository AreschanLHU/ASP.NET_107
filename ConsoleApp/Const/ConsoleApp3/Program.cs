using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            //pi = 3.14; //已經為常數不可被改變
            int r = 2;

            Console.WriteLine("半徑為 " + r + " 的圓, 其面積為: " + (pi * r * r));
            Console.Read();
        }
    }
}
