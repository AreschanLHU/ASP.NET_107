using System;

namespace DataType2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int: 4 bytes, double: 8 bytes
            
            int x = 1;
            double d = x; // implicit
            Console.WriteLine(d);
            d = 2.35;
            Console.WriteLine(d);

            x = (int)d; // 執行 explicit 宣告, 其值可能失去精準度
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
