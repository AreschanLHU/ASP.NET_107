using System;

namespace ConsoleApp4
{
    class Program
    {
        //Enumerations 列舉資料型態
        enum Evar{a, b, c=7, d, e=d};
        static void Main(string[] args)
        {
            Console.WriteLine("Evar.a = " + Evar.a);
            Console.WriteLine("(int)Evar.a = " + (int)Evar.a);
            Console.WriteLine("(int)Evar.b = " + (int)Evar.b);
            Console.WriteLine("(int)Evar.c = " + (int)Evar.c);
            Console.WriteLine("(int)Evar.d = " + (int)Evar.d); //d = Evar[c] + 1
            Console.WriteLine("(int)Evar.e = " + (int)Evar.e);
            Console.Read();
        }
    }
}
