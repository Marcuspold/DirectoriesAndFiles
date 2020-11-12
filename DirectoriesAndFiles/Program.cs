using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning Captain!");
            string rootpath = @"C:\Users\opilane\Samples";
            string[] alldirectories = Directory.GetDirectories(rootpath);
            ReadArray(alldirectories);

            //get nested directories
            string[] includeNestedDirectories = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
            ReadArray(includeNestedDirectories);

            //get directory files
            string[] files = Directory.GetFiles(rootpath, "*.*,", SearchOption.AllDirectories);
            ReadArray(files);

        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
