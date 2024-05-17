using System;
using System.IO;

namespace FileDeletionAppWithSubdirectories
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
                string[] files = Directory.GetFiles(folderPath, searchPattern, SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    File.Delete(file);
                    Console.WriteLine($"Deleted: {file}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
