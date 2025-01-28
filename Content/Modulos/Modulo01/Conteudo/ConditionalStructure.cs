using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.Conteudo
{

    class ConditionalStructure
    {
        static void ExemploImparOuPar(string[] args)
        {
            // if = se   - else = se não..

            Console.WriteLine("Entre com um número inteiro: ");

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) // % mod = resto de divisão
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");

            }
        }
    }
}
