using System;
using System.Linq;

namespace _14_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS IN C#\n");

            // Arrays are used to store multiple values in a single variable

            // Decalration as well as initialization
            string[] cars = {"Audi", "BMW", "Ferrari"};
            int[] nums = {10, -20, 30, -400};

            // Accessing Array Elements
            Console.WriteLine("1. "+cars[0]);
            Console.WriteLine("2. "+nums[2]);

            // Changng an Array Element
            cars[0] = "Kwid";
            Console.WriteLine("3. "+cars[0]);

            // Array Length
            Console.WriteLine("4. "+cars.Length);

            // Loop through an Array
            Console.WriteLine("5. Cars:");
            for (int i = 0; i < cars.Length; i++){
                Console.WriteLine("\t"+cars[i]);
            }

            // foreach loop in an array
            Console.WriteLine("6. Cars:");
            foreach(string car in cars){
                Console.WriteLine("\t"+car);
            }

            // Sorting an Array
            // Array.Sort() : it sorts an array alphabetically or in an ascending order
            Array.Sort(cars); // it will arrange alphabetically
            Console.WriteLine("7. Cars:");
            foreach(string car in cars){
                Console.WriteLine("\t"+car);
            }

            Array.Sort(nums); // it will arrange in ascending order
            Console.WriteLine("8. Numbers:");
            foreach(int num in nums){
                Console.WriteLine("\t"+num);
            }

            // System.Linq Namespace : Some useful array methods, such as Min(), Max(), and Sum() are present in `System.Linq`
            int[] numbers = {10,7,5,-8};
            int result;

            result = numbers.Max(); // returns the largest value
            Console.WriteLine("9. "+result);

            result = numbers.Min(); // returns the smallest value
            Console.WriteLine("10. "+result);

            result = numbers.Sum(); // returns the sum of elements
            Console.WriteLine("11. "+result);

            // Ways to create an array

            // Method 1: Create an array of four elements, and add values later
            string[] cars1 = new string[4];

            // Method 2: Create an array of four elements and add values right away 
            string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // Method 3: Create an array of four elements without specifying the size 
            string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            // Method 4: Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"}; 

            /*
            NOTE:

            1) You should try to use Method 4 to create an array as it is fast and easy to read.
            2) [ IMP ] If you declare an array and initialize it later, you have to use the `new` keyword. Adding the values without using `new` will cause an error.
            */

            // Example
            string[] cars5; // Declare an array
            cars5 = new string[] {"Volvo", "BMW", "Ford"}; // Add values, using new
            Console.WriteLine("12. Cars:");
            foreach(string car in cars5){
                Console.WriteLine("\t"+car);
            }

            /*
            OUTPUT:

            ARRAYS IN C#

            1. Audi
            2. 30
            3. Kwid
            4. 3
            5. Cars:
                Kwid
                BMW
                Ferrari
            6. Cars:
                Kwid
                BMW
                Ferrari
            7. Cars:
                BMW
                Ferrari
                Kwid
            8. Numbers:
                -400
                -20
                10
                30
            9. 10
            10. -8
            11. 14
            12. Cars:
                Volvo
                BMW
                Ford
            */
        }
    }
}
