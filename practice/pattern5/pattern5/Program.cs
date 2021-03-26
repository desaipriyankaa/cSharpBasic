using System;

namespace pattern5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int l = 1; l <= i; l++)
                {
                    Console.Write("*");
                }

                for (int m=2; m<=i; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
