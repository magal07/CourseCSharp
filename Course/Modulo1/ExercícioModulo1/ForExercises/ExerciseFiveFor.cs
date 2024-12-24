using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.ExercícioModulo1.ForExercises
{
    internal class ExerciseFiveFor
    {
        static void Exercise5For(string[] args)
        {
            {

                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Divisores: " + i);
                    }
                }
            }
        }
    }
}
