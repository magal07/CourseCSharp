using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo1.Conteudo
{
    internal class While // while = enquanto - se a condição do while for verdadeira ele executa e volta, se for falsa ele pula fora
    {
        static void WhileEnquanto(string[] args)
        {
                Console.Write("Digite um número : ");
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)

            {
                double raiz = Math.Sqrt(x);
                
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");
        }
    }
}
