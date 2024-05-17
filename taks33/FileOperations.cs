using System;
using System.IO;

namespace FileOperationsApp
{
    public static class FileOperations
    {
        public static void SearchFiles(string folderPath, string searchPattern)
        {
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

        public static void SearchFilesWithSubdirectories(string folderPath, string searchPattern)
        {
            try
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern, SearchOption.AllDirectories);
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

        public static void DeleteFiles(string folderPath, string searchPattern)
        {
            try
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern);
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

        public static void DeleteFilesWithSubdirectories(string folderPath, string searchPattern)
        {
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

        public static void DeleteFilesAndEmptyDirectories(string folderPath, string searchPattern)
        {
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

        public static void DisplayDirectoryStructure(string path)
        {
            try
            {
                DisplayDirectoryContents(path, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static void DisplayDirectoryContents(string path, int indentLevel)
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
