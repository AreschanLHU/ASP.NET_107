using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // BMI, Body Mass Index
            // BMI = Weight(kg) / Height^2(m^2)
            double bmi, weight, height;
            weight = 76.0; height = 176.0;
            bmi = weight / (height / 100) / (height / 100);
            // bmi = w / ((h/100)*(h/100));
            Console.WriteLine("體重: " + weight + " kg, 身高: " + height + "cm,\nBMI: " + bmi);
            Console.WriteLine("取小數後二位:\n" + "體重: " + weight + " kg, 身高: " + height + "cm,\nBMI: " + String.Format("{0:0.00}",bmi));
            Console.Read();
        }
    }
}
