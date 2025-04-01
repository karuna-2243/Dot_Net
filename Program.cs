 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String Value");
            String str = Console.ReadLine();
            Console.WriteLine(str);

            if (int.TryParse(str, out int intValue))
            {
                Console.WriteLine($"Converted to Integer: {intValue}");
            }
            else if (bool.TryParse(str, out bool boolValue))
            {
                Console.WriteLine($"Converted to Boolean: {boolValue}");
            }
            else if (double.TryParse(str, out double doubleValue))
            {
                Console.WriteLine($"Converted to Double: {doubleValue}");
            }
            else if (decimal.TryParse(str, out decimal decimalValue))
            {
                Console.WriteLine($"Converted to Decimal: {decimalValue}");
            }
            else if (DateTime.TryParse(str, out DateTime dateTimeValue))
            {
                Console.WriteLine($"Converted to DateTime: {dateTimeValue}");
            }
            else
            {
                Console.WriteLine("Unable to convert the input to a recognized data type.");
            }
        }
    }
}
