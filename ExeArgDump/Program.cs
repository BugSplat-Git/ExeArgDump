using System;
using System.IO;

namespace ExeArgDump
{
    class Program
    {
        static void Main(string[] args)
        {
            var guid = Guid.NewGuid();
            var fileName = $"{guid}.log";
            Console.WriteLine($"Writing log to {fileName}");
            using (var outputFile = new StreamWriter(fileName))
            {
                foreach (string arg in args)
                {
                    outputFile.WriteLine(arg);
                }
            }
        }
    }
}
