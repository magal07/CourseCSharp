using System.IO;
using System.Linq.Expressions;

namespace Course
{
    internal class ProgramUsing
    {
        static void UsingProgram(string[] args)
        {
            string path = @"c:\temp\file1.txt";

            try
            {
                // BLOCO USING
                //using (FileStream fs = new FileStream(path, FileMode.Open)) 
                using (StreamReader sr = File.OpenText(path)) // tirei a linha de cima e reajustei pra File.OpenText

                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}