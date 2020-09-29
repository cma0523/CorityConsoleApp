using System;
using System.IO;

namespace CorityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the file name.");
                var fileName = Console.ReadLine();
                Console.WriteLine("Start processing file.");
                var fileProcessor = new FileProcessor();
                var status = fileProcessor.TextFileOutput(fileName);
                Console.WriteLine(status ? "File has been processed." : "File cannot be processed.");
            }
        }

    }
}
