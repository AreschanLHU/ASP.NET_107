using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            //byte a = 256; //錯誤
            int b = 255;
            uint c = 255;
            short d = 255;
            long e = 355;
            float f = 10.2f; //float 必須加 f/F後墜字, 避免成 double 造成錯誤
            double g = 255.0;
            //double g = 255; //轉換 
            char h = 'h';
            bool i = true;
            string j = "j";

            Console.WriteLine("a = " + a + ", size of a = " + sizeof(byte));
            Console.WriteLine("b = " + b + ", size of b = " + sizeof(int));
            Console.WriteLine("c = " + c + ", size of c = " + sizeof(uint));
            Console.WriteLine("d = " + d + ", size of d = " + sizeof(short));
            Console.WriteLine("e = " + e + ", size of e = " + sizeof(long));
            Console.WriteLine("f = " + f + ", size of f = " + sizeof(float));
            Console.WriteLine("g = " + g + ", size of g = " + sizeof(double));
            Console.WriteLine("h = " + h + ", size of h = " + sizeof(char));
            Console.WriteLine("i = " + i + ", size of i = " + sizeof(bool));
            //Console.WriteLine("j = " + j + ", size of j = " + sizeof(string)); //錯誤; str is reference
            Console.Read();
        }
    }
}
