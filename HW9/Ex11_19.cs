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
        public void UpdateInventory(string inventoryFileName, string updateFileName)
        {
            string[,] updateFileArray = FileToArray(updateFileName);
            string[,] inventoryFileArray = FileToArray(inventoryFileName);
            //DisplayArrayContents(inventoryFileArray);
            UpdateInventoryArray(inventoryFileArray, updateFileArray);
            //DisplayArrayContents(inventoryFileArray);

            string newFileName = NewFile(inventoryFileArray);
            DisplayFileContents("Initial inventory file", inventoryFileName);
            DisplayFileContents("Update to inventory file", updateFileName);
            DisplayFileContents("Updated inventory file", newFileName);

            Console.ReadLine();
        }

        private static string[,] FileToArray(string fileName)
        {
            int lineCount = CountFileLines(fileName);
            string[,] array = new string[lineCount, 3];
            StreamReader fileReader = new StreamReader(fileName);
            string line;
            int i = 0;

            while ((line = fileReader.ReadLine()) != null)
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

                i++;
            }
            fileReader.Close();
            return array;
        }

        private static int CountFileLines(string fileName)
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

        private static void UpdateInventoryArray(string[,] inventoryArray, string[,] updateArray)
        {
            for (int i = 0; i < updateArray.GetLength(0); i++)
            {
                for (int j = 0; j < inventoryArray.GetLength(0); j++)
                {
                    if (inventoryArray[j, 0] == updateArray[i, 0])
                    {
                        int originalQuantity = int.Parse(inventoryArray[j, 2]);
                        int quantityChange = int.Parse(updateArray[i, 2]);
                        string newQuantity = (originalQuantity + quantityChange).ToString();
                        inventoryArray[j, 2] = newQuantity;
                    }
                }
            }
        }

        private static string NewFile(string[,] array)
        {
            string fileName = "newInventory.txt";
            StreamWriter s = new StreamWriter(fileName);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                s.WriteLine($"{array[i, 0]} | " +
                    $"{array[i, 1]} | {array[i, 2]}");
            }

            s.Close();
            return fileName;
        }

        private static void DisplayFileContents(string heading, string fileName)
        {
            StreamReader fileReader = new StreamReader(fileName);
            string line;

            Console.WriteLine(heading);

            while ((line = fileReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            fileReader.Close();
            Console.WriteLine();
        }

        private static void DisplayArrayContents(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"{array[i, 0]} | " +
                    $"{array[i, 1]} | {array[i, 2]}");
            }

        }
    }
}
