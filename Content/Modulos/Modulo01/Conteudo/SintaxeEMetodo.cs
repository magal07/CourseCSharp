using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.Conteudo
{
    internal class SintaxeEMetodo
    {
        static void MetodoESintaxe(string[] args)
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
        // CRIAÇÃO DO MÉTODO MAIOR


        static int Maior(int a, int b, int c)
        {


            if (a > b && a > c)
            {

                return a;
                Console.WriteLine("n1 é o maior!");
            }

            else if (b > c)
            {

                return b;
                Console.WriteLine("n2 é o maior!");
            }

            else
            {
                return c;
                Console.WriteLine("n3 é o maior!");
            }
        }
    }
}
