using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo1.ExercíciosModulo1
{
    class ExerciseWhile
    {

        static void ExerciseKey(string[] args)
        {

            Console.WriteLine("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");
        }

    }

}