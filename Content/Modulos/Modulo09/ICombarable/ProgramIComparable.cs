using Course.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ProgramIComparable
    {
        static void IComparableProgram(string[] args)
        {

            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path)) // ABRIR ARQUIVO COM O STREAM READER
                {
                    List<Employee> list = new List<Employee>(); // CRIAR UMA LISTA
                    while (!sr.EndOfStream) // PERCORRER O ARQUIVO
                    {
                        list.Add(new Employee(sr.ReadLine())); // ENQUANTO N FOR O FINAL DO ARQUIVO VOU ADD NA LIST
                    }
                    list.Sort(); // ordenando a list de A a Z
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("AAn error ocurred");
                Console.WriteLine(e.Message);
            }
        
        }
    }
}
