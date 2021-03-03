using System;

namespace FileSystem_Class_Ex._8._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class FileSystemInfo
    {
        public FileSystemInfo(string name, long totalSpace, long freeSpace)
        {
            DiskName = name;
            DiskVolume = totalSpace;
            FreeSpace = freeSpace;
        }

        public string DiskName { get; }
        public long DiskVolume { get; }
        public long FreeSpace { get; }

    }
}
