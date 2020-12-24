using System;

namespace _26_EquilateralTriangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            n = 10; // 10 is the length of side of an equilateral triangle. You can also change this value.

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= ((2 * n) - 1); j++)
                {
                    if (i != n)
                    {
                        if (i + j < n + 1)
                        {

                            Console.Write(" ");
                        }
                        else if (i + j == n + 1)
                        {
                            Console.Write("*");
                        }
                        else if (i + j > n + 1)
                        {
                            if (j - i < n - 1)
                            {
                                Console.Write(" ");
                            }
                            else if (j - i == n - 1)
                            {
                                Console.Write("*");
                            }
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("* ");
                        }
                    }
                }
                Console.Write("\n");
            }

            /*
            OUTPUT:

                     *
                    * *
                   *   *
                  *     *
                 *       *
                *         *
               *           *
              *             *
             *               *
            * * * * * * * * * * 
            
            */
        }
    }
}
