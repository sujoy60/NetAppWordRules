using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandlingWordRules
{
    public class WriteToTextFile
    {

        public void writeToFile(float result, string fileName)
        { 
            string[] lines = { result.ToString() };
            File.WriteAllLines(fileName, lines);
        }
    }
}
