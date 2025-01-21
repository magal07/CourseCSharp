using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3.Exercises
{
    internal class ExerciseMatriz
    {
        static void MatrizExercise(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            
            for (int i =0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    mat[i,j]= int.Parse(values[j]);
                }
            }
            // lógica para descobrir a diagonal principal
            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");

            }
            Console.WriteLine();

            // estrutura básica para percorrer uma matriz inteira 

            int count = 0;

            for (int i = 0;i < n; i++) // percorre o i
            {
                for (int j=0; j <n; j++) // percorre o j dentro do i
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }

    }
}
