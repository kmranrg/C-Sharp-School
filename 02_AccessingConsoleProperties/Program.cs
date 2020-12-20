using System;

namespace _02_AccessingConsoleProperties
{
  class Program
  {
    static void Main(string[] args)
    {
      // Changing the Console Appearance
      Console.Title = "AI Killer 1.0";
      Console.ForegroundColor = ConsoleColor.Green;

      // Get a conversation going
      Console.WriteLine("Hello, what is your name?");
      
      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nMy name is RX-9000. \nI'm an AI sent from the future to destroy mankind");
      Console.WriteLine("What is your hobby?");

      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nCool, mine is destruction");

      Console.ForegroundColor = ConsoleColor.White;

      /*
      OUTPUT:

      Hello, what is your name?
      Anurag

      My name is RX-9000. 
      I'm an AI sent from the future to destroy mankind
      What is your hobby?
      Playing Cricket

      Cool, mine is destruction
      */
    }
  }
}
