using System;

namespace _22_Interface
{
    interface IFirstInterface 
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface 
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface 
    {
        public void myMethod() 
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod() 
        {
            Console.WriteLine("Some other text...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACE\n");

            /*
            KNOWLEDGE CLOUD:

            1) Like abstract classes, interfaces cannot be used to create objects.
            2) Another way to achieve abstraction in C#, is with interfaces.
            3) C# does not directly support Multiple Inheritance
            4) But it can be achieved with interfaces, because the class can implement multiple interfaces.
            */

            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();

            /*
            OUTPUT:

            INTERFACE

            Some text..
            Some other text...
            */
        }
    }
}
