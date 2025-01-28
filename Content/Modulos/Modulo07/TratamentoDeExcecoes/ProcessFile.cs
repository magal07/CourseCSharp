using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModuloDeEstudo.Modulo7.TratamentoDeExcecoes
{
    public class ProcessFile
    {
        public static void ContentFinally(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\Temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally // finally = irá executar uma ação, independente se deu try ou catch
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
    }
    }
}
