using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "output.txt"; // File to store data

            // Taking user input
            Console.Write("Enter a string to append to the file: ");
            string userInput = Console.ReadLine();

            // Appending text to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(userInput);
            }

            Console.WriteLine("Text appended successfully!");
        }
    }
}
