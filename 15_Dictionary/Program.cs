using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DICTIONARY\n");

            /*
            KNOWLEDGE CLOUD: Dictionary Characteristics

            1. Dictionary<TKey, TValue> stores key-value pairs.
            2. Comes under `System.Collection.Generic` namespace.
            3. Implements IDictionary<TKey, TValue> interface.
            4. Keys must be unique and cannot be null.
            5. Values can be null or duplicate.
            6. Values can be accessed by passing associated key in the indexer e.g. myDictionary[key]
            7. Elements are stored as KeyValuePair<TKey, TValue> objects.
            */
            
            // 1. Declaring a dictionary variable
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1,"One"); //adding key/value using the Add() method
            numberNames.Add(2,"Two");
            numberNames.Add(5,"Five");

            // 2. Accessing the keys and values stored inside dictionary
            Console.WriteLine("1. NumberNames Dictionary:");
            foreach(KeyValuePair<int, string> kvp in numberNames){
                Console.WriteLine("\tKey: {0} | Value: {1}",kvp.Key, kvp.Value);
            }

            // 3. Creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"UK","London, Manchester, Birmingham"},
                {"USA","Chicago, New York, Washington"},
                {"India","Mumbai, New Delhi, Pune"}
            };

            // 4. Accessing the keys and values stored inside dictionary made by collection-initializer syntax
            Console.WriteLine("2. Cities Dictionary:");
            foreach(var kvp in cities){
                Console.WriteLine("\tKey: {0} | Value: {1}",kvp.Key,kvp.Value);
            }

            // 5. Accesing one key value pair of a dictionary
            string result;
            result = cities["USA"];
            Console.WriteLine("3. Cities of USA: "+result);

            // 6. How to check whether a key is present in a dictionary or not
            if(cities.ContainsKey("France")){
                Console.WriteLine("4. "+cities["France"]);
            }else {
                Console.WriteLine("4. No key found with France");
            }

            // 7. Using TryGetValue() to get a value of unknown key
            if(cities.TryGetValue("France", out result))
            {
                Console.WriteLine("5. "+result);
            }else if(cities.TryGetValue("UK", out result))
            {
                Console.WriteLine("5. "+result);
            }

            // 8. How to find out total no of key-value pairs present inside a dictionary
            int totalDictionaryElements = cities.Count;
            Console.WriteLine("6. Total no of key-value pairs present: {0}",totalDictionaryElements); 

            // 9. Using `ElementAt()` to retrieve key-value pair using index.
            /*
            NOTE: 
            
            1) for using `ElementAt()` you need to use `System.Linq` namespace.
            2) LINQ stands for Language Integrated Query.
            */
            Console.WriteLine("7. Cities Dictionary using for loop:");
            for (int i = 0; i < cities.Count; i++){
                Console.WriteLine("\tKey: {0} | Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }

            // 10. Updating Dictionary
            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
            Console.WriteLine("8. Cities Dictionary:");
            foreach(var kvp in cities){
                Console.WriteLine("\tKey: {0} | Value: {1}",kvp.Key,kvp.Value);
            }

            // 11. Removing Elements in Dictionary

            // Remove() : this method is used to delete an existing key-value pair from a dictionary. It takes key as a parameter.
            cities.Remove("UK");
            Console.WriteLine("9. Cities Dictionary:");
            foreach(var kvp in cities){
                Console.WriteLine("\tKey: {0} | Value: {1}",kvp.Key,kvp.Value);
            }

            // Clear() : this method wil remove all the elements at once
            cities.Clear();
            Console.WriteLine("10. Total no of elements present in Cities Dictionary is : {0}",cities.Count);

            /*
            OUTPUT:

            DICTIONARY

            1. NumberNames Dictionary:
                Key: 1 | Value: One
                Key: 2 | Value: Two
                Key: 5 | Value: Five
            2. Cities Dictionary:
                Key: UK | Value: London, Manchester, Birmingham
                Key: USA | Value: Chicago, New York, Washington
                Key: India | Value: Mumbai, New Delhi, Pune
            3. Cities of USA: Chicago, New York, Washington
            4. No key found with France
            5. London, Manchester, Birmingham
            6. Total no of key-value pairs present: 3
            7. Cities Dictionary using for loop:
                Key: UK | Value: London, Manchester, Birmingham
                Key: USA | Value: Chicago, New York, Washington
                Key: India | Value: Mumbai, New Delhi, Pune
            8. Cities Dictionary:
                Key: UK | Value: Liverpool, Bristol
                Key: USA | Value: Los Angeles, Boston
                Key: India | Value: Mumbai, New Delhi, Pune
            9. Cities Dictionary:
                Key: USA | Value: Los Angeles, Boston
                Key: India | Value: Mumbai, New Delhi, Pune
            10. Total no of elements present in Cities Dictionary is : 0
            */

        }
    }
}
