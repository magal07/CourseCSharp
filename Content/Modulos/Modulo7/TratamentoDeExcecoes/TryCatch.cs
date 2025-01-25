using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Course.ModuloDeEstudo.Modulo7.TratamentoDeExcecoes
{
    internal class TryCatch
    {
        static void ContentTryCatch(string[] args)
        {
            DateTime minutoSegundo = DateTime.Now;
            try // tentar 

            {
                int n = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                int div = n / y;

                Console.WriteLine("Result: " + div);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message + " " + DateTime.Now.ToString("mm:ss"));
            }
        }
    }
}
