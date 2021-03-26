using System;

namespace varkeyword
{
    class Program 
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.4, 34.8, 23.67, 45.76 };
            var result = 0.0;
            foreach (var number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
