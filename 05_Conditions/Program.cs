using System;

namespace _05_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Comparison Operators:

            1) == : equal to
            2) != : not equal to
            3) > : greater than
            4) < : lesser than
            5) >= : greater than or equal to
            6) <= : less than or equal to
            */

            Console.WriteLine("MOVIE COUNTER\n");
            Console.WriteLine("Welcome! Tickets are 5$. Please insert cash.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5) {
                Console.WriteLine("That's not enough money.");
            } else if (cash == 5) {
                Console.WriteLine("Here's your ticket.");
            } else {
                int change = cash - 5;
                Console.WriteLine("Here's your ticket and "+ change +"$ in change.");
            }

            Console.WriteLine("\n\nKID CIRCUS\n");

            int age;
            int height;

            Console.Write("Please input age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input height(cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && height >= 160) {
                Console.WriteLine("You can enter!");
            } else {
                Console.WriteLine("You don't meet requirements.");
            }

            /*
            OUTPUT:

            MOVIE COUNTER

            Welcome! Tickets are 5$. Please insert cash.
            14
            Here's your ticket and 9$ in change.


            KID CIRCUS

            Please input age: 22
            Please input height(cm): 180
            You can enter!
            */
        }
    }
}
