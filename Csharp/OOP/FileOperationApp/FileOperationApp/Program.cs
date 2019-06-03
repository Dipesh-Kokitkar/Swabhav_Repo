using System;
using System.IO;

namespace FileOperationApp
{
    class Program
    {
        const string FILE = @"D:\Swabhav Respositry\Csharp\OOP\FileOperationApp\FileOperationApp\example.txt";
        static void Main(string[] args)
        {
            string line;
            ReadFile();
            while ((line = Console.ReadLine()) != "Exit")
            {
                WriteFile(line);
            }
            ReadFile();
        }
        static void ReadFile()
        {
            try
            {
                string line;
                using (StreamReader Sr = new StreamReader(FILE))
                {
                    while ((line = Sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("File not found!" + e.Message);
            }

        }

        static void WriteFile(string line)
        {
            using (StreamWriter SW = new StreamWriter(FILE))
            {
                SW.WriteLine(line + " ");
            }
        }
    }
}
