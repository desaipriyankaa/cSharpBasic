using System;

namespace IfStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =35;
            int b = 50;
            int c = 30;

            if (a < b & a < c)
            {

                if (b == c)
                {
                    Console.WriteLine("A is less than B and c ....... B is equal to c");
                }
                else if (b < c)
                {
                    Console.WriteLine("A is less than B and c ....... B is less than c.....A is smallest and C is greatest");
                }
                else
                {
                    Console.WriteLine("A is less than B and c ....... B is greater than c......A is smallest and B is greatest");
                }


            }

            else if (a > b & a < c)
            {

                Console.WriteLine("A is greater than B and less than c....... B is less than C......B is smallest and C is greatest");

            }

            else if (a > b & a > c)
            {

                if (b == c)
                {
                    Console.WriteLine("A is greater than b and c.....B is equal to C ....A is greatest");
                }
                else if (b < c)
                {
                    Console.WriteLine("A is greater than b and c.....B is less than C ....A is greatest");
                }
                else
                {
                    Console.WriteLine("A is greater than b and c.....B is greater than C ....A is greatest");
                }

            }

            else 
            {

                Console.WriteLine("A is less than B and greater than c....... B is greatest and C is smallest");
            
            }
        }
    }
}
