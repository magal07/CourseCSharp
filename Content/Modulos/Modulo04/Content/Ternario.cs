using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.ModulosDeEstudo.Modulo4.Content
{
    internal class Ternario
    {
        static void TernarioConditional(string[] args)
        {
            // funções alternativas para IF/ELSE = Operações Ternárias

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // a condicional ternária pode substituir um if/else

            double desconto = preco < 20.0 ? preco * 0.1 : preco * 0.05;

            /* com if / else 

            if(preco < 20)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            } */

            Console.WriteLine(desconto);
        }
    }
}
