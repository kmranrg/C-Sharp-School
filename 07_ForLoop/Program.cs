using System;

namespace _07_ForLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("LOOPS\n");

      Console.WriteLine("Natural Numbers from 1 to 10 using for loop:");
      for (int i = 1; i <= 10; i++)
      {
        Console.WriteLine(i);
      }

      Console.WriteLine("\n\nCar names using foreach loop:\n");
      string[] cars = { "BMW", "Audi", "Ford", "Swift" };
      foreach (string car in cars)
      {
        Console.WriteLine(car);
      }

      /*
        OUTPUT:

        LOOPS

        Natural Numbers from 1 to 10 using for loop:
        1
        2
        3
        4
        5
        6
        7
        8
        9
        10


        Car names using foreach loop:

        BMW
        Audi
        Ford
        Swift
      */
    }
  }
}
