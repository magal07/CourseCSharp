using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1.ForExercises
{
    internal class ExerciseTwoFor
    {
        static void Execise2For(string[] args)
        {


            int N = int.Parse(Console.ReadLine()); // definir o N

            int cont_in = 0; // contar números dentro do intervalo
            int cont_out = 0; // contar números fora do intervalo

            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine()); // chamar o X
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1; // Exemplo básico 
                }
                else
                {
                    cont_out += +1; // Exemplo Resumido
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }
}
