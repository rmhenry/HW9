using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW9
{
    public class Ex11_19
    {
        //private string[,] updateFileContents;
        //private string[,] inventoryFileContents;

        public void UpdateInventory(string inventoryFileName, string updateFileName)
        {
            int lineCount = CountFileLines(updateFileName);
            string[,] updateFileContents = new string[lineCount, 3];

            lineCount = CountFileLines(inventoryFileName);
            string[,] inventoryFileContents = new string[lineCount, 3];

            FileToArray(updateFileName, updateFileContents);

            for (int i = 0; i < updateFileContents.GetLength(0); i++)
            {
                Console.WriteLine($"Item Number {updateFileContents[i, 0]} | " +
                    $"Item {updateFileContents[i, 1]} | Quantity {updateFileContents[i, 2]}");
            }

            Console.ReadLine();
        }

        private int CountFileLines(string fileName)
        {
            StreamReader fileReader = new StreamReader(fileName);
            int lineCount = 0;

            while (fileReader.ReadLine() != null)
            {
                lineCount++;
            }

            fileReader.Close();
            return lineCount;
        }

        private void FileToArray(string fileName, string[,] array)
        {
            StreamReader fileReader = new StreamReader(fileName);
            string line;

            while ((line = fileReader.ReadLine()) != null)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    string[] currentLine = line.Split('|');
                    if (currentLine.Length == 3)
                    {
                        array[i, 0] = currentLine[0].Trim();
                        array[i, 1] = currentLine[1].Trim();
                        array[i, 2] = currentLine[2].Trim();
                    }
                    else if (currentLine.Length == 2)
                    {
                        array[i, 0] = currentLine[0].Trim();
                        array[i, 1] = "N/A";
                        array[i, 2] = currentLine[1].Trim();
                    }
                    else
                    {
                        Console.WriteLine("The specified file does not have the expected number of values per line.");
                    }


                }

            }

            fileReader.Close();
        }
    }
}
