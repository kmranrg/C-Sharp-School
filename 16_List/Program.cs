using System;
using System.Collections.Generic;

namespace _16_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LIST\n");

            /*
            KNOWLEDGE CLOUD:

            1) It comes under System.Collection.Generic namespace.
            2) Elements can be accessed by passing an index e.g. myList[0]. Indexes start from zero.
            */

            // 1) Creating a List
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");

            // adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                            {
                                "New York",
                                "London",
                                "Chicago"
                            };
            // 2) Adding an array in a List
            string[] myCities = {"Chennai", "Kolkata", "Bengaluru", "Chennai"};

            var popularCities = new List<string>();
            popularCities.AddRange(myCities);
            // now adding a list to an existing list
            var favoriteCities = new List<string>();
            favoriteCities.AddRange(popularCities);

            // 3) Accessing a List using for loop
            Console.WriteLine("1. Prime Numbers List:");
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.WriteLine("\t"+primeNumbers[i]);
            }

            // 4) Accessing a List using foreach LINQ method
            Console.WriteLine("2. Cities List:");
            cities.ForEach(city => Console.WriteLine("\t"+city));

            // 5) Inserting Elements in a List
            bigCities.Insert(1, "UP"); // it is going to insert "UP" at index 1

            // 6) Accesing the List using foreach
            Console.WriteLine("3. Big Cities:");
            foreach(var city in bigCities){
                Console.WriteLine("\t"+city);
            }

            // 7) Removing elements from List
            popularCities.Remove("Chennai"); // it will remove the first occurence of "Chennai"
            
            Console.WriteLine("4. Popular Cities:");
            foreach(var city in popularCities){
                Console.WriteLine("\t"+city);
            }

            // 8) RemoveAt() : it takes index value as an argument and removes the value present at that index
            favoriteCities.RemoveAt(3); //  it will remove the 4th element of list

            Console.WriteLine("5. Favorite Cities:");
            foreach(var city in favoriteCities){
                Console.WriteLine("\t"+city);
            }

            // 9) How to check whether an element is present in the list or not
            var myFavNumbers = new List<int>() {10,20,30};
            bool is20Present = myFavNumbers.Contains(20); // it will return True if 20 is present in list otherwise return False
            Console.WriteLine("6. "+is20Present);
            
            if(is20Present == true){
                Console.WriteLine("7. 20 is present");
            }else {
                Console.WriteLine("7. 20 is not present");
            }

            /*
            OUTPUT:

            LIST

            1. Prime Numbers List:
                1
                3
                5
            2. Cities List:
                New York
                London
                Mumbai
            3. Big Cities:
                New York
                UP
                London
                Chicago
            4. Popular Cities:
                Kolkata
                Bengaluru
                Chennai
            5. Favorite Cities:
                Chennai
                Kolkata
                Bengaluru
            6. True
            7. 20 is present
            */

        }
    }
}
