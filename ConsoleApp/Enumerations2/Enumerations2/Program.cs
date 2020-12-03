using System;

namespace Enumerations2
{
    class Program
    {
        enum weeks{Mon=1,Tue, Wed, Thu, Fri, Sat, Sun};
        static void Main(string[] args)
        {
            Console.WriteLine("Mon: "+ (int)weeks.Mon);
            Console.WriteLine("Tue: " + (int)weeks.Tue);
            Console.WriteLine("Wed: " + (int)weeks.Wed);
            Console.WriteLine("Thu: " + (int)weeks.Thu);
            Console.WriteLine("Fri: " + (int)weeks.Fri);
            Console.WriteLine("Sat: " + (int)weeks.Sat);
            Console.WriteLine(weeks.Sun + ": " + (int)weeks.Sun);
            Console.Read();
        }
    }
}
