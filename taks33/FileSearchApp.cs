using System;
using System.IO;

namespace FileSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the folder path: ");
            string folderPath = Console.ReadLine();

            Console.Write("Enter the search pattern (e.g., *.txt): ");
            string searchPattern = Console.ReadLine();

            try
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
