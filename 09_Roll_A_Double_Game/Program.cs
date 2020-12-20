using System;

namespace _09_Roll_A_Double_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLASSIC ROLL A DOUBLE GAME\n");

            // let's generate an object of Random class
            Random randomNo = new Random();

            int roll1 = -1;
            int roll2 = -2;
            int attempts = 0;

            Console.WriteLine("Press enter key to roll\n");

            while(roll1 != roll2){
                Console.ReadKey();

                roll1 = randomNo.Next(1,7); // it will generate a random no from 1 to 6
                roll2 = randomNo.Next(1,7); // it will generate a random no from 1 to 6

                Console.WriteLine("Roll on 1st dice: "+ roll1);
                Console.WriteLine("Roll on 2nd dice: "+ roll2+"\n");

                attempts++;
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nIt took you "+ attempts + " attempts to roll a double.");
            
            Console.ForegroundColor = ConsoleColor.White;

            /*
            OUTPUT:

            CLASSIC ROLL A DOUBLE GAME

            Press enter key to roll

            Roll on 1st dice: 2
            Roll on 2nd dice: 3

            Roll on 1st dice: 5
            Roll on 2nd dice: 5


            It took you 2 attempts to roll a double.
            */
        }
    }
}
