using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3.Exercises
{
    internal class ExerciseMatrizSolo
    {
        static void MatrizUpLeftDownRight(string[] args)
        {
            // Lê a primeira linha de entrada e divide os valores
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]); // Número de linhas da matriz
            int n = int.Parse(line[1]); // Número de colunas da matriz

            // Declaração da matriz bidimensional com as dimensões lidas
            int[,] mat = new int[m, n];

            // Loop para ler os valores da matriz
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' '); // Lê os valores da linha e divide-os
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]); // Converte e armazena na matriz
                }
            }

            // Lê o valor que será buscado na matriz
            int x = int.Parse(Console.ReadLine());

            // Percorre a matriz para encontrar o valor
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x) // Se o valor for encontrado
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        // Verifica e imprime o valor à esquerda, se existir
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        // Verifica e imprime o valor acima, se existir
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        // Verifica e imprime o valor à direita, se existir
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }

                        // Verifica e imprime o valor abaixo, se existir
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
