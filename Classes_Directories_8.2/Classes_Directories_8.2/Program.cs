using System;
using System.IO;

namespace Classes_Directories_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Size: {drive.TotalSize}");
                    Console.WriteLine($"Space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Tag: {drive.VolumeLabel}");
                }
            }
        }
    }
}
