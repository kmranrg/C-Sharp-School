using System;

namespace _08_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHILE LOOP\n");
            Console.WriteLine("Print first 10 multiples of 5 using while loop");
            int i = 1;
            while(i <= 10) {
                Console.Write(5*i+" ");
                i++;
            }

            Console.WriteLine("\n\nDO-WHILE LOOP\n");
            Console.WriteLine("Print first 10 multiples of 5 using do-while loop");
            int j = 1;
            do{
                Console.Write(5*j+" ");
                j++;
            }while(j<=10);

            /*
            OUTPUT:

            WHILE LOOP

            Print first 10 multiples of 5 using while loop
            5 10 15 20 25 30 35 40 45 50 

            DO-WHILE LOOP

            Print first 10 multiples of 5 using do-while loop
            5 10 15 20 25 30 35 40 45 50 
            */

        }
    }
}