using System;
using System.IO; // for data file handling

namespace _25_DataFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATA FILE HANDLING\n");

            // Writing to a file and then reading it

            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("myFile.txt", writeText);  // Create a file and write the content of writeText to it

            writeText = "\nMy name is Kumar Anurag and my twitter id is kmranrg.";
            File.AppendAllText("myFile.txt",writeText); // it adds the content at the end of the file

            string readText = File.ReadAllText("myFile.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

            /*
            OUTPUT:

            DATA FILE HANDLING

            Hello World!
            My name is Kumar Anurag and my twitter id is kmranrg.
            */

        }
    }
}
