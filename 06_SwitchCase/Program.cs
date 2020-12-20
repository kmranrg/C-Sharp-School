using System;

namespace _06_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cash(1-5) and I will write it in words.");

            int cash;
            cash = Convert.ToInt32(Console.ReadLine());

            switch(cash) {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Please enter cash between 1 to 5...");
                    break;
            }

            /*
            OUTPUT:

            Enter the cash(1-5) and I will write it in words.
            15
            Please enter cash between 1 to 5...
            */
        }
    }
}
