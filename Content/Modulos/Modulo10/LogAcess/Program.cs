using System;
using System.IO;
using Course.Entities;
namespace Course
{
    class ProgramABC10
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path)) // ler o path
                {
                    while (!sr.EndOfStream)
                    {
                        // guardando no vector line - leitura da linha - recorte das partes do vector
                        string[] line =             sr.ReadLine().Split(' '); 
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });                    }
                }
                Console.WriteLine("Total users: " + + set.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}