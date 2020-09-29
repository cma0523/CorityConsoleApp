using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace CorityConsoleApp
{
    public class FileProcessor
    {
        private readonly string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public bool TextFileOutput(string fileName)
        {
            string text;
            try
            {
                var fullpath = Path.Combine(directory, fileName);
                if (!File.Exists(fullpath)) return false;
                if (!Path.GetExtension(fullpath).Equals(".txt", StringComparison.OrdinalIgnoreCase)) return false;
                //Read entire text
                using (var sr = new StreamReader(fullpath))
                {
                    text = sr.ReadToEnd();
                }
                //Write same text to output file, overwrite the text if file exists
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(directory, fileName + ".out"), false))
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
