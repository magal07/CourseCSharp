using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.ExercícioModulo1
{
    internal class ExerciseSixFor
    {
        static void ExerciseSixFor(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}