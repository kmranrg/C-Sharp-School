using System;

namespace _11_TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TYPE CASTING\n");

            /*
            KNOWLEDGE CLOUD:

            Type Casting is when you assign a value of one data type into another data type

            There are two types of type casting in C#:

            1) Implicit Casting (automatically): converting a smaller type to a larger type size
                                                 char -> int -> long -> float -> double
            
            2) Explicit Casting (manually): converting a larger type to a smaller size type
                                                 double -> float -> long -> int -> char
            */

            // Example 1 : Implicit Type Casting
            int num = 10;
            double d = num;

            Console.WriteLine("1. "+num);
            Console.WriteLine("2. "+d);

            // Example 2 :  Explicit Type Casting
            double d1 = 9.8;
            int num1 = (int) d1;

            Console.WriteLine("3. "+d1);
            Console.WriteLine("4. "+num1);

            // Example 3 : Type Conversion Methods
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine("5. "+Convert.ToString(myInt));    // convert int to string
            Console.WriteLine("6. "+Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine("7. "+Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine("8. "+Convert.ToString(myBool));   // convert bool to string

            /*
            OUTPUT:

            TYPE CASTING

            1. 10
            2. 10
            3. 9.8
            4. 9
            5. 10
            6. 10
            7. 5
            8. True
            */
        }
    }
}
