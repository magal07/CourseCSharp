using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.Conteudo
{
    class EstruturaIfEncadeamentos
    {
        static void ExampleGoodMorningGoodAfertnoonGoodNight(string[] args)
        {
            /* MÉTODO 1 BOM DIA/TARDE/NOITE/MADRUGA
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine()); 

            if (hora >= 06 && hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
          if  (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            if (hora >= 18 && hora <= 24)
            {
                Console.WriteLine("Boa noite!");
            }
            if (hora < 06 && hora > 01)
            {
                Console.WriteLine("Boa madrugada! rsrs"); */

            // Método mais utilizado!

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora <= 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("Digite um horário dentro do período de 01h até o período de 24h");
            }
        }
    }

}
