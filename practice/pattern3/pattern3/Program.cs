using System;

namespace pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<5; i++)
            {
                for (int j=0; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            for (int i = 4; i >=0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
