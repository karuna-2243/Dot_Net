using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take input from the user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // 1. Convert to uppercase (Example of a string function)
            string upperCaseString = input.ToUpper();
            Console.WriteLine("Uppercase: " + upperCaseString);

            // 2. Reverse the string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed: " + reversedString);

            // 3. Replace spaces with '-'
            string replacedString = input.Replace(" ", "-");
            Console.WriteLine("Replaced Spaces: " + replacedString);

            // 4. Get length of the string
            int length = input.Length;
            Console.WriteLine("Length of the string: " + length);

            // Find occurrences of 'l' and their positions
            int count = 0;
            Console.Write("Positions of 'l': ");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'l')
                {
                    count++;
                    Console.Write(i + " "); // Print position of 'l'
                }
            }
            Console.WriteLine("\nNumber of times 'l' appears: " + count);

            // Formatting output as *H*e*l*l*o*
            string formattedOutput = "*" + string.Join("*", input.ToCharArray()) + "*";
            Console.WriteLine("Formatted Output: " + formattedOutput);
        }
    }
}
