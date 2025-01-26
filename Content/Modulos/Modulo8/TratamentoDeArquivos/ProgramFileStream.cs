using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ProgramFileStream
    {
        public static void FileStreamProgram(string[] args)
        {
            string path = @"C:\temp\file1.txt";
            //FileStream fs = null; // realiza a leitura em binários
            StreamReader sr = null; // realiza a leitura dos binários em caracteres

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs); método complexo
                sr = File.OpenText(path); // método genérico e mais simples
                while (!sr.EndOfStream) // enquanto eu não chegar no final da stream, eu vou ler uma linha
                {
                 string line = sr.ReadLine();
                  Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
            finally
            {
                //if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
