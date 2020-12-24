using System;

namespace _23_MethodOverloading
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("METHOD OVERLOADING\n");

            /*
            KNOWLEDGE CLOUD:

            1) With method overloading, multiple methods can have the same name with different parameters
            */

            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            /*
            OUTPUT:

            METHOD OVERLOADING

            Int: 13
            Double: 10.559999999999999
            */
        }
    }
}
