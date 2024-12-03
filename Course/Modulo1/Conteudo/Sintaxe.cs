using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.Conteudo
{
    internal class Sintaxe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

/* RESUMO DE LÓGICA EM FUNÇÃO, CLIQUE AQUI

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }

            Console.WriteLine("Este é o maior valor considerando as outras variáveis"); */ 


            double resultado = Maior(n1, n2, n3);   

            Console.WriteLine("Maior = " + resultado); 
        }
        // CRIAÇÃO DO MÉTODO 
        static int Maior(int a, int b, int c)
        {
            int m; // MAIOR

            if (a > b && a > c)
            {
                m = a;
            }

            else if (b > c)
            {
                m = b;
            }
            else
            {
                m= c;
            }

            return m;
        }
    }
}
