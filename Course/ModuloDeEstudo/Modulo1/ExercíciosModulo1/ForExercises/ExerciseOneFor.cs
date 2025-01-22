using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1.ForExercises
{
    internal class ExerciseOneFor
    {
        static void Exercise1For(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0) // Definindo para que seja par
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}
