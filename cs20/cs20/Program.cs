using System;
using System.IO;

namespace cs20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DriveInfo drive = new DriveInfo("C");
            // dùng để lấy ra ổ đĩa cố định trong máy
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Drive: {drive.Name}");
                Console.WriteLine($"Drive Type: {drive.DriveType}");
                Console.WriteLine($"Label: {drive.VolumeLabel}");
                Console.WriteLine($"Format: {drive.DriveFormat}");
                Console.WriteLine($"Size: {drive.TotalSize}");
                Console.WriteLine($"Free: {drive.TotalFreeSpace}");
                Console.WriteLine("--------------------");
            }


        }
    }
}
