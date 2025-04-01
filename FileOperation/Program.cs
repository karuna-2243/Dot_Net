using System;
using System.IO;

class FileOperations
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("File Operations Menu:");
            Console.WriteLine("1. Read from a file");
            Console.WriteLine("2. Write to a file");
            Console.WriteLine("3. List files in a directory");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    ReadFromFile();
                    break;
                case "2":
                    WriteToFile();
                    break;
                case "3":
                    ListFilesInDirectory();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;  // Exit the program
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        }
    }

    // Method to read from a file
    static void ReadFromFile()
    {
        Console.Write("Enter the path of the file to read: ");
        string filePath = Console.ReadLine();

        try
        {
            if (File.Exists(filePath))  // Check if the file exists
            {
                string content = File.ReadAllText(filePath);  // Read the file content
                Console.WriteLine("\nFile Content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found. Please check the file path.");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Access to the file is denied.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method to write to a file
    static void WriteToFile()
    {
        Console.Write("Enter the path of the file to write to: ");
        string filePath = Console.ReadLine();

        Console.Write("Enter the text you want to write to the file: ");
        string textToWrite = Console.ReadLine();

        try
        {
            // If file exists, append; otherwise, create a new file
            File.AppendAllText(filePath, textToWrite + Environment.NewLine);
            Console.WriteLine("Text written to the file successfully.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Access to the file is denied.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method to list files in a directory
    static void ListFilesInDirectory()
    {
        Console.Write("Enter the directory path to list files: ");
        string directoryPath = Console.ReadLine();

        try
        {
            if (Directory.Exists(directoryPath))  // Check if the directory exists
            {
                string[] files = Directory.GetFiles(directoryPath);  // Get all files in the directory
                Console.WriteLine("\nFiles in the directory:");

                foreach (string file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));  // Display only the file name
                }
            }
            else
            {
                Console.WriteLine("Directory not found. Please check the directory path.");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Access to the directory is denied.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
