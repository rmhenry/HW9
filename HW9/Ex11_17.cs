using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW9
{
    public class Ex11_17
    {
        public void SearchForText(string fileName, string searchText)
        {
            string line;
            int currentLine = 1;
            int foundOnLine = 0;
            StreamReader f = new StreamReader(fileName);

            while ((line = f.ReadLine()) != null)
            {
                if (line.Contains(searchText))
                    foundOnLine = currentLine;
                currentLine++;
            }

            f.Close();

            Console.WriteLine();
            Console.WriteLine($"File name = {fileName}");
            Console.WriteLine($"Searched for text = '{searchText}'");
            if (foundOnLine > 0)
                Console.WriteLine($"'{searchText}' found in line {foundOnLine}");
            else
                Console.WriteLine($"'{searchText}' was not found.");
        }
    }
}
