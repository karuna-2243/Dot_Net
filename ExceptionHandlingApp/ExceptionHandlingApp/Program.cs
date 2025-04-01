using System;
using MyOperations;

class Program
{
    static void Main()
    {
        //Operations operations = new Operations();

        //// Test Divide by Zero
        //try
        //{
        //    int result = operations.Divide(10, 0);
        //    Console.WriteLine($"Result: {result}");
        //}
        //catch (MyCustomException ex)
        //{
        //    Console.WriteLine(ex.ToString());
        //}

        //// Test Index Out of Range
        //try
        //{
        //    int[] arr = { 1, 2, 3 };
        //    int value = operations.GetArrayElement(arr, 5);
        //    Console.WriteLine($"Array Element: {value}");
        //}
        //catch (MyCustomException ex)
        //{
        //    Console.WriteLine(ex.ToString());
        //}




        Operations operations = new Operations();

        Console.WriteLine("=== Console Application for MyOperations ===");

        // Test Divide by Zero
        Console.WriteLine("\n1. Testing Division by Zero:");
        try
        {
            Console.Write("Enter numerator: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter denominator: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = operations.Divide(a, b);
            Console.WriteLine($"Result: {result}");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine(ex.ToString());
        }

        // Test Index Out of Range
        Console.WriteLine("\n2. Testing Index Out of Range:");
        try
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.Write("Enter the index to access (0-4): ");
            int index = Convert.ToInt32(Console.ReadLine());

            int value = operations.GetArrayElement(arr, index);
            Console.WriteLine($"Array Element at index {index}: {value}");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine("\nApplication has finished execution.");
    }
}
