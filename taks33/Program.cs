using System;

namespace FileOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Search files");
                Console.WriteLine("2. Search files with subdirectories");
                Console.WriteLine("3. Delete files");
                Console.WriteLine("4. Delete files with subdirectories");
                Console.WriteLine("5. Delete files and empty directories");
                Console.WriteLine("6. Display directory structure");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 7) break;

                Console.Write("Enter the folder path: ");
                string folderPath = Console.ReadLine();

                if (choice != 6)
                {
                    Console.Write("Enter the search pattern (e.g., *.txt): ");
                    string searchPattern = Console.ReadLine();

                    switch (choice)
                    {
                        case 1:
                            FileOperations.SearchFiles(folderPath, searchPattern);
                            break;
                        case 2:
                            FileOperations.SearchFilesWithSubdirectories(folderPath, searchPattern);
                            break;
                        case 3:
                            FileOperations.DeleteFiles(folderPath, searchPattern);
                            break;
                        case 4:
                            FileOperations.DeleteFilesWithSubdirectories(folderPath, searchPattern);
                            break;
                        case 5:
                            FileOperations.DeleteFilesAndEmptyDirectories(folderPath, searchPattern);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    FileOperations.DisplayDirectoryStructure(folderPath);
                }

                Console.WriteLine();
            }
        }
    }
}
