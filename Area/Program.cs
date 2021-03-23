using System;

namespace Area
{
    abstract class shape
    {
        public abstract int area();
    }

    class rectangle : shape
    {
        private int length;
        private int width;

        public rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override int area()
        {

            Console.WriteLine("Rectangle area : ");
            return (width*length);
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle(20, 15);
            double a = r.area();

            Console.WriteLine("Area :{0}",a);
            Console.ReadKey();
        }
    }
}
