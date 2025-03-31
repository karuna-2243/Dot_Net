
using System;

namespace ConsoleTextColorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the console text color to Green
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This text is in Green!");

            // Set the console text color to Red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This text is in Red!");

            // Reset to the default console color
            Console.ResetColor();
            Console.WriteLine("This text is in the default color.");
        }
    }
}

