using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3.Content
{
    internal class Matrizes
    {
        static void MatrizesContent(string[] args)
        {
            double[,] mat = new double[2, 3]; // informa que a matriz será 2 linhas e 3 colunas

            Console.WriteLine(mat.Length); // informa elementos a matriz tem no total

            Console.WriteLine(mat.Rank); // busca quantas linhas temos no total (1 ª dimensão)

            Console.WriteLine(mat.GetLength(0)); // a dimensão 0 da matriz tem tamanho 2 (tamanho de linhas)

            Console.WriteLine(mat.GetLength(1)); // a dimensão 1 da matriz tem tamanho 3 (tamanho de colunas)

        }
    }
}
