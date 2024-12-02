using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.ExercícioModulo1
{
    class DataEntryExerciseSequential3
    {
        static void ExerciseDiferenca(string[] args)
        {


            int a, b, c, d, calculo;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());



            calculo = a * b - c * d;

            Console.WriteLine("Calculo = " + calculo);

            // IZZI
        }
    }
}
