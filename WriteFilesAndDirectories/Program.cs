
using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePaths();
        }



        public static void WriteFilePaths()
        {
            string FilePath = @"C:\Users\opilane\Samples\Files.txt";
            string directoryPath = @"C:\Users\opilane\Samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            //save to file
            File.WriteAllLines(FilePath, files);
        }
            
            

           
           
        
        
    }
}
