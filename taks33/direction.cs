using System;
using System.IO;

namespace DirectoryStructureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the folder path: ");
            string folderPath = Console.ReadLine();

            try
            {
                DisplayDirectoryContents(folderPath, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void DisplayDirectoryContents(string path, int indentLevel)
        {
            string indent = new string(' ', indentLevel * 2);

            foreach (var dir in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{indent}[DIR] {Path.GetFileName(dir)}");
                DisplayDirectoryContents(dir, indentLevel + 1);
            }

            foreach (var file in Directory.GetFiles(path))
            {
                Console.WriteLine($"{indent}{Path.GetFileName(file)}");
            }
        }
    }
}
