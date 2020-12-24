using System;

namespace _21_Abstraction
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TIPS AND TRICKS\n");
            int x = 24>>3; // it is equivalent to: ( 24 / (Math.Pow(2,3)) )
            int y = 24<<4; // it is equivalent to: ( 24 * (Math.Pow(2,4)) )
            Console.WriteLine(x + " | " + y);

            Console.WriteLine("\nABSTRACTION\n");

            /*
            KNOWLEDGE CLOUD:

            1) Data abstraction is the process of hiding certain details and showing only essential information to the user.
            2) Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
            3) Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
            */
            
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method

            /*
            OUTPUT:

            TIPS AND TRICKS

            3 | 384

            ABSTRACTION

            The pig says: wee wee
            Zzz
            */
        }
    }
}
