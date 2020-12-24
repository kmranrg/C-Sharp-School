using System;

namespace _24_ExceptionHandling
{
    class MyException : Exception
    {
        public string status;
        public MyException(string myMessage)
        {
            Console.WriteLine("\nERROR: "+myMessage);
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXCEPTION HANDLING\n");

            /*
            KNOWLEDGE CLOUD:

            1) try : The try statement allows you to define a block of code to be tested for errors while it is being executed.
            2) catch : The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
            3) The try and catch keywords come in pairs.
            4) finally : The finally statement lets you execute code, after try...catch, regardless of the result
            */

            try
            {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("You encountered an error. | Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            Console.WriteLine("\n----------\n");
            Console.WriteLine("USER DEFINED EXCEPTION\n");

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32( Console.ReadLine() );

            if(age < 18)
            {
                try {
                    throw new MyException("Sorry, age must be greater than 18");
                } catch (MyException err) {
                    err.status = "Come, when you are more than 18 years old.";
                    Console.WriteLine(err.status);
                }

            } else 
            {
                Console.WriteLine("Access granted - You are old enough!");
            }

            /*
            OUTPUT:

            EXCEPTION HANDLING

            You encountered an error. | Error: Index was outside the bounds of the array.
            The 'try catch' is finished.

            ----------

            USER DEFINED EXCEPTION

            Enter your age: 10

            ERROR: Sorry, age must be greater than 18
            Come, when you are more than 18 years old.
            */
        }
    }
}
