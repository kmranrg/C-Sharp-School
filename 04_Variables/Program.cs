using System;

namespace _04_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Rules for constructing names of variables(unique identifiers):

            1) Names can contain letters, digits and the underscore character (_)
            2) Names must begin with a letter
            3) Names cannot contain whitespace
            4) Names are case sensitive
            5) Reserved words (like C# keywords, such as int or double) cannot be used as names
            */

            Console.WriteLine("MULTIPLICATION:\n");

            double num01;
            double num02;
            
            Console.Write("Enter first number: ");
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Enter second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            double result = num01 * num02;
            Console.WriteLine("Multiplication: "+result);

            /*
            OUTPUT:

            MULTIPLICATION:

            Enter first number: 5
            Enter second number: 2.5
            Multiplication: 12.5
            */
        }
    }
}
