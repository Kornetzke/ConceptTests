using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Mains(string[] args)
        {
            int numberOfFiles = 1000;
            string location = @"C:\Users\Kyle\Desktop\ReadMe";

            Console.WriteLine("Press any key to Start.");
            Console.ReadKey();

            Directory.CreateDirectory(location);

            List<string> prev = new List<string>();

            for (int x = 0; x < numberOfFiles; x++)
            {
                prev.Add("Hello, You are File " + x);
                File.WriteAllLines(location + @"\readme" + x + ".txt",prev.ToArray());
                
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
