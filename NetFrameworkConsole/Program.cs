using System;
using System.IO;

namespace NetFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.EnumerateDirectories(@"C:\");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
