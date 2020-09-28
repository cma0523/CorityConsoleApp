using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace CorityConsoleApp
{
    public class FileProcessor
    {
        private readonly string directory = "C:/temp/";
        public bool OutputTextFile(string fileName)
        {
            string text;
            try
            {
                //Create a new folder if it exists
                //If the folder exists already, the line will be ignored.
                Directory.CreateDirectory(directory);
                var fullpath = directory + fileName;
                if (!File.Exists(fullpath)) return false;
                //Read entire text
                using (var sr = new StreamReader(fullpath))
                {
                    text = sr.ReadToEnd();
                }
                //Write entire text
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(directory, fileName + ".out"), true))
                {
                    outputFile.WriteLine(text);
                }

                return true;
            }

            catch (Exception ex)
            {
                return false;
            }

        }



    }
}
