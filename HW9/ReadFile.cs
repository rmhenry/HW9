using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW9
{
    public class ReadFile
    {
        public void ReadFileTest(String[] args)
        {
            String line;
            int totalLines;   // number of lines to read  
            int count = 0;    // number of lines read so far 
            totalLines = int.Parse(args[1]);
            StreamReader f = new StreamReader(args[0]);
            while ((line = f.ReadLine()) != null
                   && count++ < totalLines)
                Console.WriteLine(line);
            f.Close();
        }

    }
}
