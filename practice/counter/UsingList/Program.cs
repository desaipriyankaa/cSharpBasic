using System;
using System.Collections.Generic;

namespace UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades=new List<double>() { 12.3, 32.3, 46.65, 53.44, 43.43 };
             var result = 0.0;

             foreach (var number in grades)
             {
                 result += number;

             }
             Console.WriteLine($"addition of grade is {result:n3}");

             result /= grades.Count;
             Console.WriteLine($"the average grade is {result:n5}");
        }
    }
}
