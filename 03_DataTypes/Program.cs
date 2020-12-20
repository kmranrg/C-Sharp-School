using System;

namespace _03_DataTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Data Types;

      1) int : 4 bytes | Stores whole numbers from -2,147,483,648 to 2,147,483,647
      2) long : 8 bytes | Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
      3) float : 4 bytes | Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
      4) double : 8 bytes | Stores fractional numbers. Sufficient for storing 15 decimal digits
      5) bool : 1 bit | Stores true or false values
      6) char : 2 bytes | Stores a single character/letter, surrounded by single quotes
      7) string : 2 bytes per character | Stores a sequence of characters, surrounded by double quotes
      */

        // int
        int myNum1 = 10000;
        Console.WriteLine("1. I am of "+ myNum1.GetType() + " and my value is "+ myNum1);

        // long : this is used when `int` is not large enough to store the value
        long myNum2 = 15000000000L; // NOTE: the value should end with `L`
        Console.WriteLine("2. I am of "+ myNum2.GetType() + " and my value is "+ myNum2);

        // float : the value should end with `F`
        float myNum3 = 5.75F;
        Console.WriteLine("3. I am of "+ myNum3.GetType() + " and my value is "+ myNum3);

        // double : the value should end with `D`
        double myNum4 = 19.99D;
        Console.WriteLine("4. I am of "+ myNum4.GetType() + " and my value is "+ myNum4);

        // Scientific Numbers : A floating point number can also be a scientific number with an "e" to indicate the power of 10
        float f1 = 3e2F;
        Console.WriteLine("5. I am of "+ f1.GetType() + " and my value is "+ f1);
        double d1 = 3e4D;
        Console.WriteLine("6. I am of "+ d1.GetType() + " and my value is "+ d1);

        // bool
        bool isCSharpAmazing = true; // NOTE: `true` will be in lower case only but `isCSharpAmazing` will contain `True` with `T` as capital
        Console.WriteLine("7. I am of "+ isCSharpAmazing.GetType() + " and my value is "+ isCSharpAmazing);

        bool isFishTasty = false;
        Console.WriteLine("8. I am of "+ isFishTasty.GetType() + " and my value is "+ isFishTasty);

        // char : the value should be surrounded by single quotes
        char c1 = 'a';
        Console.WriteLine("9. I am of "+ c1.GetType() + " and my value is "+ c1);

        // string : the value should be surrounded by double quotes
        string s1 = "Hello Anurag";
        Console.WriteLine("10. I am of "+ s1.GetType() + " and my value is "+ s1);

        /*
        OUTPUT:

        1. I am of System.Int32 and my value is 10000
        2. I am of System.Int64 and my value is 15000000000
        3. I am of System.Single and my value is 5.75
        4. I am of System.Double and my value is 19.99
        5. I am of System.Single and my value is 300
        6. I am of System.Double and my value is 30000
        7. I am of System.Boolean and my value is True
        8. I am of System.Boolean and my value is False
        9. I am of System.Char and my value is a
        10. I am of System.String and my value is Hello Anurag
        */
    }
  }
}
