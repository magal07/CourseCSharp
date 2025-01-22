using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1
{
    class DataEntryExerciseSequential4
    {
        static void ExerciseOverTime(string[] args)
        {

            int funcionarioNumber, horasTrabalhadas;
            double valorHora;

            funcionarioNumber = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo = horasTrabalhadas * valorHora;

            Console.WriteLine($"Number:  {funcionarioNumber}");
            Console.WriteLine($"Salary = U$ {calculo.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
