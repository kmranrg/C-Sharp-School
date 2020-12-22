using System;

namespace _17_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. MEET ALIEN\n");

            MeetAlien();
            Console.WriteLine("\n-------\n");
            MeetAlien();
            Console.WriteLine("\n-------\n");
            
            Console.WriteLine("\n2. SQUARE OF A NUMBER\n");

            int sq = Square(4);
            Console.WriteLine("The square of a number is "+sq);

            Console.WriteLine("\n-------\n");

            Console.WriteLine("\n3. WORD COUNT\n");

            Console.Write("Enter a sentence: ");
            string userString = Console.ReadLine();
            int count = WordCount(userString);
            Console.WriteLine("Total no of words in the sentence are: "+count);

            /*
            OUTPUT:

            1. MEET ALIEN

            Hi, I'm R-2558
            I'm 269 years old.
            Oh, I'm an alien.

            -------

            Hi, I'm R-3221
            I'm 325 years old.
            Oh, I'm an alien.

            -------


            2. SQUARE OF A NUMBER

            The square of a number is 16

            -------


            3. WORD COUNT

            Enter a sentence: I love coding
            I converted the sentence into an array of words: 
                I
                love
                coding
            Total no of words in the sentence are: 3
            */
        }

        static void MeetAlien()
        {
            Random numberGen = new Random();
            
            string name = "R-" + numberGen.Next(10,9999);
            int age = numberGen.Next(10,500);

            Console.WriteLine("Hi, I'm "+ name);
            Console.WriteLine("I'm "+ age +" years old.");
            Console.WriteLine("Oh, I'm an alien.");
        }

        static int Square(int x)
        {
            int result = x * x;
            return result;
        }

        static int WordCount(string s)
        {
            string[] wordsArray =  s.Split(" "); // here Split(" ") is going to break the sentence at every `space`
            Console.WriteLine("I converted the sentence into an array of words: ");
            foreach(var word in wordsArray){
                Console.WriteLine("\t"+word);
            }
            return wordsArray.Length;
        }
    }
}
