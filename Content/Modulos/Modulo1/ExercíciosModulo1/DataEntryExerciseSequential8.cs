using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1
{
    class DataEntryExerciseSequential8
    {
        static void ExerciseClassificationIntervals(string[] args)

        {

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo!");

            }
            else if (numero <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
        }
    }
}
