using System;

namespace pattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j=5; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int l=1; l <= i; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
