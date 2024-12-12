using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Course.Modulo1.Conteudo
{
    class forEmCSharp
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos números inteiros você vai digitar? ");

            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Valor #{0}", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = ", soma);
        }
    }
}