using System;
using System.Collections.Generic;
using System.Globalization;
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
            List<decimal> inputs = new List<decimal>();
            try
            {
                var fullpath = Path.Combine(directory, fileName);
                if (!File.Exists(fullpath)) return false;
                if (!Path.GetExtension(fullpath).Equals(".txt", StringComparison.OrdinalIgnoreCase)) return false;
                //Read entire text
                string line;
                using (var sr = new StreamReader(fullpath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            inputs.Add(Decimal.Parse(line));
                        }
                    }
                }

                var billService = new BillService();
                var result = billService.SplitBills(inputs);

                //Write same text to output file, overwrite the text if file exists
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(directory, fileName + ".out"), false))
                {
                    foreach (var item in result)
                    {
                        foreach (var bill in item)
                        {
                            outputFile.WriteLine(bill>0 ? "$" + bill.ToString("0.##") 
                                : "$(" + bill.ToString("0.##") + ")");
                        }
                        outputFile.WriteLine("");
                    }
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
