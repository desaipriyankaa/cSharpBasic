using System;

namespace DiamondNumber
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
                    Console.Write(l);
                }

                for (int m = 2; m <= i; m++)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }


            for (int i = 6; i <= 10; i++)
            {
                for (int j = 6; j <= i + 1; j++)
                {
                    Console.Write(" ");
                }

                for (int l = 9; l >= i; l--)
                {
                    Console.Write(l);
                }

                for (int m = 8; m >= i; m--)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }
        }
    }
}
