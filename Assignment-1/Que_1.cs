using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            string input = Console.ReadLine();

            // Convert to Integer
            if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine($"Integer: {intValue}");
            }
            else
            {
                Console.WriteLine("Invalid integer format.");
            }

            // Convert to Boolean
            if (bool.TryParse(input, out bool boolValue))
            {
                Console.WriteLine($"Boolean: {boolValue}");
            }
            else
            {
                Console.WriteLine("Invalid boolean format.");
            }

            // Convert to DateTime
            if (DateTime.TryParse(input, out DateTime dateTimeValue))
            {
                Console.WriteLine($"DateTime: {dateTimeValue}");
            }
            else
            {
                Console.WriteLine("Invalid DateTime format.");
            }

            // Convert to Double
            if (double.TryParse(input, out double doubleValue))
            {
                Console.WriteLine($"Double: {doubleValue}");
            }
            else
            {
                Console.WriteLine("Invalid double format.");
            }

            // Convert to Decimal
            if (decimal.TryParse(input, out decimal decimalValue))
            {
                Console.WriteLine($"Decimal: {decimalValue}");
            }
            else
            {
                Console.WriteLine("Invalid decimal format.");
            }
        }
    }
    }

