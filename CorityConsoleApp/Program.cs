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
                Console.WriteLine("Please enter the file name, if you want to exit the program, please enter ");
                var fileName = Console.ReadLine();
                Console.WriteLine("Start processing file.");
                var fileProcessor = new FileProcessor();
                var status = fileProcessor.OutputTextFile(fileName);
                if()
                Console.WriteLine("File has been processed,");
            }
        }

    }
}
