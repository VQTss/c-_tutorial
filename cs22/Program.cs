using System.IO;
using System;

namespace cs22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Path.DirectorySeparatorChar);
            var path = Path.Combine("Dir1","test.txt");
            path = Path.ChangeExtension(path,"hmt");
            Console.WriteLine(path);
            Console.WriteLine($"Directory: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"Extension: {Path.GetExtension(path)}");
            Console.WriteLine($"Name File: {Path.GetFileName(path)}");
            Console.WriteLine($"Get full path {Path.GetFullPath(path)}");
            Console.WriteLine($"Random file name {Path.GetRandomFileName()}");
        }

    }
}
