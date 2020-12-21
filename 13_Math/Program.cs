using System;

namespace _13_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# MATH\n");

            double result;

            // Math.Max(x,y) : this method can be used to find the highest value of x and y
            result = Math.Max(5,2);
            Console.WriteLine("1. "+result);

            // Math.Min(x,y) : this method can be used to find the lowest value of x and y
            result = Math.Min(5,2);
            Console.WriteLine("2. "+result);

            // Math.Sqrt(x) : this method returns the square root of x
            result = Math.Sqrt(25);
            Console.WriteLine("3. "+result);

            // Math.Abs(x) : this method returns the absolute (positive) value of x
            result = Math.Abs(-4.5);
            Console.WriteLine("4. "+result);
            result = Math.Abs(4.51);
            Console.WriteLine("5. "+result);

            // Math.Round() : it rounds a number to the nearest whole number
            result = Math.Round(9.99);
            Console.WriteLine("6. "+result);

            /*
            OUTPUT:

            C# MATH

            1. 5
            2. 2
            3. 5
            4. 4.5
            5. 4.51
            6. 10
            */
        }
    }
}
