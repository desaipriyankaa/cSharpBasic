using System;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1000;
            double b = 200.45;
            string d = "good morning";
            bool c = true;
            string str = "425256"; 

            //casting
            // b = a;//implicit casting... no data loss
            //Console.WriteLine("value of b (implicit casting) : " + b);


            //a = (int)b;//explicit casting... there is data loss
            //Console.WriteLine("value of a (explicit casting) : "+a);


            a = Convert.ToInt32(str);
            Console.WriteLine("value of a (conversion) : " +a);


             Console.WriteLine("Hello world!");
        }
    }
}
