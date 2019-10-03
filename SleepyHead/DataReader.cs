using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace SleepyHead
{
    public class DataReader
    {

        public List<string[]> ReadCSV(string csvPath, string delimiter)
        {
            List<string[]> csvContent = new List<string[]>();
            using (TextFieldParser csvParser = new TextFieldParser(csvPath))
            {
                csvParser.SetDelimiters(delimiter);

                while (!csvParser.EndOfData)
                {
                    csvContent.Add(csvParser.ReadFields());
                }
            }
            return csvContent;
        }
    }
}
