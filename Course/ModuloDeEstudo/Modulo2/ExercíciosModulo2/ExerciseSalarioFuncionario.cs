using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Course.ModulosDeEstudo.Modulo2.ClassesEMetodosDosExercícios;

namespace Course.ModulosDeEstudo.Modulo2.ExercíciosModulo2
{
    public class ExerciseSalarioFuncionario
    {
        static void ExerciseMediaSalarial(string[] args)
        {

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados dos funcionários: ");
            Console.WriteLine();

            Console.WriteLine("Nome do funcionário 1: ");
            f1.NomeFuncionario = Console.ReadLine();
            Console.WriteLine("Salário do funcionário: ");
            f1.SalarioFuncionario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Nome do funcionário 2: ");
            f2.NomeFuncionario = Console.ReadLine();
            Console.WriteLine("Salário do funcionário 2: ");
            f2.SalarioFuncionario = double.Parse(Console.ReadLine());

            double media = (f1.SalarioFuncionario + f2.SalarioFuncionario) / 2.0; // calculo das médias

            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));




        }

    }
}
