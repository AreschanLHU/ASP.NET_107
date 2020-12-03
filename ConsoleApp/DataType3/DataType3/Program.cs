using System;

namespace DataType3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 資料型態轉換 System.Convert
            // ToString, ToInt32, ToSingle, ToDouble
            string a = "5.2", b = "6.3";
            double x = Convert.ToDouble(a); // str to double
            double y = Convert.ToDouble(b); // str to double
            double result = x * y;
            Console.WriteLine(result.ToString()); // double to str
            Console.Read();
        }
    }
}
