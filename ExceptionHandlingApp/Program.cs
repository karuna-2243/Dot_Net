using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_2_Delegates___Exceptional_Handling;

namespace ExceptionHandlingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Operations operations = new Operations();

            // Test Divide by Zero
            try
            {
                int result = operations.Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Test Index Out of Range
            try
            {
                int[] arr = { 1, 2, 3 };
                int value = operations.GetArrayElement(arr, 5);
                Console.WriteLine($"Array Element: {value}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
