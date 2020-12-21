using System;

namespace _10_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPERATORS\n");

            /*
            Arithmetic Operators:

            1) + : Addition Operator
            2) - : Subtraction Operator
            3) * : Multiplication Operator
            4) / : Division Operator
            5) % : Modulus Operator
            6) ++ : Increment
            7) -- : Decrement

            Comparison Operators:

            1) == : Equal to
            2) != : Not equal
            3) > : Greater than
            4) < : Less than
            5) >= : Greater than or equals to
            6) <= : Lesser than or euals to

            Logical Operators:

            1) && : Logical and
            2) || : Logical or
            3) ! : Logical not
            */

            // Example : Arithmetic Operators

            Console.Write("Enter first number: ");
            int x = Convert.ToInt32( Console.ReadLine() );
            
            Console.Write("Enter second number: ");
            int y = Convert.ToInt32( Console.ReadLine() );

            double res;

            res = x + y;
            Console.WriteLine("Addition of x and y is: "+res);

            res = x - y;
            Console.WriteLine("Subtraction of x and y is: "+res);

            res = x * y;
            Console.WriteLine("Multiplication of x and y is: "+res);

            res = (x + 0.0) / (y + 0.0) ;
            Console.WriteLine("Division of x and y is: "+res);

            res = x % y;
            Console.WriteLine("Modulus of x and y is: "+res);
            

            // Example : Comparison Operators
            
            if(x == y) {
                Console.WriteLine("Both numbers are equal");
            } else if (x > y) {
                Console.WriteLine("First number is greater");
            } else {
                Console.WriteLine("Second number is greater");
            }

            // Example : Logical Operators

            if( x >= 1 && x <= 10) {
                Console.WriteLine("First number is between 1 and 10");
            } else {
                Console.WriteLine("First number is not between 1 and 10");
            }

            /*
            OUTPUT:

            OPERATORS

            Enter first number: 5
            Enter second number: 2
            Addition of x and y is: 7
            Subtraction of x and y is: 3
            Multiplication of x and y is: 10
            Division of x and y is: 2.5
            Modulus of x and y is: 1
            First number is greater
            First number is between 1 and 10
            */

        }
    }
}
