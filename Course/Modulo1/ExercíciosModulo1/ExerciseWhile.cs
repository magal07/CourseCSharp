using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.ExercícioModulo1
{
    class ExerciseWhile
    {

        static void ExerciseKey(String[] args)
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