﻿using System;
using System.IO;

namespace Classes_Directories_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirName = new DirectoryInfo(@"C:\Users\King Arthur\Desktop\");
            if (dirName.Exists)
            {
                DirectoryInfo testFolder = new DirectoryInfo(@"C:\Users\King Arthur\Desktop\testFolder");
                if (!testFolder.Exists)
                    testFolder.Create();
            }

            



            /*            DriveInfo[] drives = DriveInfo.GetDrives();

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
                        }*/

            /* GetCatalogs();

             static void GetCatalogs()
             {
                 string dirName = @"E:\\";
                 if (Directory.Exists(dirName))
                 {
                     Console.WriteLine("Folders:");
                     string[] dirs = Directory.GetDirectories(dirName);

                     foreach (string d in dirs)                    
                         Console.WriteLine(d);

                     Console.WriteLine();
                     Console.WriteLine("Files:");
                     string[] files = Directory.GetFiles(dirName);

                     foreach (string f in files)
                         Console.WriteLine(f);
                 }
             }*/

            /*            FilesCounter();

                        static void FilesCounter()
                        {
                            string dirName = @"C:\\";                
                            if (Directory.Exists(dirName))
                            {
                                string[] files = Directory.GetFiles(dirName);
                                Console.WriteLine(files.Length);

                                string[] folders = Directory.GetDirectories(dirName);
                                Console.WriteLine(folders.Length);

                                DirectoryInfo NewDir = new DirectoryInfo(@"/NewDir");
                                if (!NewDir.Exists)
                                    NewDir.Create();

                                NewDir.Delete(true);
                                Console.WriteLine("Directory is deleted");

                            }*/



        }

    }
}
