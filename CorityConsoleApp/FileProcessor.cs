using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace CorityConsoleApp
{
    public class FileProcessor
    {
        private readonly string directory = "C:/temp";
        public bool OutputTextFile(string fileName)
        {
            //Create a new folder if it exists
            //If the folder exists already, the line will be ignored.
            Directory.CreateDirectory(directory);
            var fullpath = directory + "/" + fileName;
            if(!File.Exists(fullpath)) return false;

            


        }



    }
}
