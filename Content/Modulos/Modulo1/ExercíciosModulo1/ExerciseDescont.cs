using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1
{
    class ExerciseDescont
    {
        static void DiscountApplicationExercise(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = 0.0;

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine($"Valor integral sem desconto = $" + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor final com o desconto aplicado = $" + (preco - desconto).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Desconto aplicado = $" + desconto.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
