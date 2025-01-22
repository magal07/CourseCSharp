using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1
{
    class DataEntryExerciseSequential6
    {

        static void ExerciseGameHoursInitialeEnd(string[] args)


        {

            string[] valores = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;

            if (horaInicio < horaFinal)
            {
                duracao = horaInicio - horaFinal;
            }

            else
            {
                duracao = 24 - horaInicio + horaFinal;

            }

            Console.WriteLine("O jogo durou " + duracao + " hora(s)");


        }
    }
}
