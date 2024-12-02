using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.Conteudo
{
    public class EntradaDeDados
    {
        static void DataEntry(string[] args)
        {

            // ReadLine = Entrada de dados pelo Prompt

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' '); // SPLIT, FUNÇÃO PRA RECORTAR UMA FUNÇÃO EM VÁRIOS PEDAÇOS (Conforme caracteres, neste caso espaço em branco '   '; //
            string a = v[0];
            string b = v[1];
            string c = v[2];

            // VETOR, ESTRUTURA QUE TEM VÁRIOS DADOS! 

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
