using Course.ModulosDeEstudo.Modulo2.ClassesEMetodosDosExercícios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModulosDeEstudo.Modulo2.ExercíciosModulo2
{
    public class ExerciseAge
    {
        static void ExercisePessoaMaisVelha(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A idade de " + p1.Nome + " é maior, portanto ela(e) é mais velha(o)");
            }
            else if (p2.Idade > p1.Idade)
            {
                Console.WriteLine("A idade de " + p2.Nome + " é maior, portanto ela(e) é mais velha(o)");
            }
            else
            {
                Console.WriteLine("As duas pessoas, " + p1.Nome + " e " + p2.Nome + " têm a mesma idade.");
            }
        }
    }
}