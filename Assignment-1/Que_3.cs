using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "output.txt"; // File to store text

            Console.Write("Enter text to append: ");
            string input = Console.ReadLine();

            // Append text to the file
            File.AppendAllText(filePath, input + Environment.NewLine);

            Console.WriteLine("\nText appended successfully!");
            Console.WriteLine("Current file content:\n" + File.ReadAllText(filePath));
        }
    }
}
    
