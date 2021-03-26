using System;
using SomeCommonLogic;

namespace datetime
{
    class Program
    { 
        static void Main(string[] args)
        {
            Class1 x = new Class1();
            Console.WriteLine("Hello World! "+x.getCurrentDateandTime());
            Console.Read();
        }
    }
}
