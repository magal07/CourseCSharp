using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Modulos.Modulo8.TratamentoDeArquivos
{
    internal class ProgramFileUpperOrLower
    {
        static void ProgramUpperFile(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                // append = acrescentar no final
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines) {
                    
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
