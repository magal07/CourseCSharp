using System.IO;

namespace Course
{
    internal class ProgramFileInfo
    {
        static void FileInfo(string[] args)
        {
            string sourcePath = @"C:\Temp\file1.txt"; // origem do path, @ = evita ter q colocar duas \\ 
            string targetPath = @"C:\Temp\file2.txt";

            try {

                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
