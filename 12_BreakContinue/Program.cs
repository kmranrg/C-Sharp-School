using System;

namespace _12_BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BREAK/CONTINUE\n");

            Console.WriteLine("\nExample: break keyword");
            // break : can be used to exit out of the loop
            for(int i = 0; i <= 5; i++){
                if(i == 3){
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("\nExample: continue keyword");
            // continue : can be used to skip the loop condition
            for(int i = 0; i <= 5; i++){
                if(i == 3){
                    continue;
                }
                Console.WriteLine(i);
            }

            /*
            OUTPUT:

            BREAK/CONTINUE


            Example: break keyword
            0
            1
            2

            Example: continue keyword
            0
            1
            2
            4
            5
            */
        }
    }
}
