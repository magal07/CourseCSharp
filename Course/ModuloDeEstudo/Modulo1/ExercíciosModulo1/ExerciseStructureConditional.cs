using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1
{
    internal class ExerciseStructureConditional
    {
        static void ExerciseMultiples(string[] args)
        {
            /* EXERCÍCIO 1 RESOLVIDO = IZZI
            int inteiro = int.Parse(Console.ReadLine());

            if (inteiro > 0)
            {
                Console.WriteLine("Positivo!");
            }
            else
            {
                Console.WriteLine("Negativo!"); */

            /*  EXERCÍCIO 2 RESOLVIDO = IZZI .. 
            int inteiro = int.Parse(Console.ReadLine());

            if (inteiro % 2 == 0) 
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("IMPAR!");
            }
            */

            Console.WriteLine("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());



            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São multiplos!");
            }
            else
            {
                Console.WriteLine("Não são multiplos!");
            }

        }
    }
}
