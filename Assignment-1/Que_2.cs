using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   // take a string 'Hello' perfrom the operation such as count the char , no of 'l' in string and separate the whole sting etc.

namespace Quetion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nResults:");
            Console.WriteLine("1. Contains 'Hello': " + input.Contains("Hello"));
            Console.WriteLine("2. Total characters: " + input.Length);
            Console.WriteLine("3. Count of 'l': " + CountChar(input, 'l'));
            Console.WriteLine("4. Formatted output: " + FormatString(input));
        }

        static int CountChar(string str, char ch)
        {
            int count = 0;
            foreach (char c in str) if (c == ch) count++;
            return count;
        }

        static string FormatString(string str)
        {
            return "*" + string.Join("*", str.ToUpper().ToCharArray()) + "*";
        }
    }
}

            

                
