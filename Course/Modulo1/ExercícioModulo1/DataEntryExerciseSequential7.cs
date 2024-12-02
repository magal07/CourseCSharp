using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo1.ExercícioModulo1
{
    internal class DataEntryExerciseSequential7
    {
        static void ExerciseBuscaCodProductValue(string[] args)
        {
            /* 
            string[] lista = Console.ReadLine().Split(' ');

            int cod = int.Parse(lista[0]);
            int quantidade = int.Parse(lista[1]);

            double total;


            if (cod == 1)
            {
                total = quantidade * 4.0;
            }
            else if (cod == 2)
            {
                total = quantidade * 4.5;
            }
            else if (cod == 3)
            {
                total = quantidade * 5.0;

            }
            else if (cod == 4)
            {
                total = quantidade * 2.0;
            }
            else {

                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture)); */

            string[] precos = Console.ReadLine().Split(' ');

            int cod = int.Parse(precos[0]);
            int quantidade = int.Parse(precos[1]);

            double total;

            if (cod == 1)
            {
                total = quantidade * 4.0;
            }
            else if (cod == 2)
            {
                total = quantidade * 4.5;
            }
            else if (cod == 3)
            {
                total = quantidade * 5.0;
            }
            else if (cod == 3)
            {
                total = quantidade * 2;
            }
            else
            {
                total = quantidade * 1.5; 
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
