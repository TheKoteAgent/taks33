using System;
using System.IO;

namespace CompleteDeletionApp
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
                    Console.WriteLine($"Deleted file: {file}");
                }

                foreach (var dir in Directory.GetDirectories(folderPath, "*", SearchOption.AllDirectories))
                {
                    if (Directory.GetFiles(dir).Length == 0 && Directory.GetDirectories(dir).Length == 0)
                    {
                        Directory.Delete(dir, false);
                        Console.WriteLine($"Deleted empty directory: {dir}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
