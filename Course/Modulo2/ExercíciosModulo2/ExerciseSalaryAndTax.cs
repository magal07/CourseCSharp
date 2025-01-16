using Course.Modulo2.ExercícioModulo2.ClassesDosExercícios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Course.Modulo2.ExercíciosModulo2
{
    public class ExerciseSalaryAndTax
    {

        static void ExercicioSalarioEImposto(string[] args)
        {
            Funcionario f = new Funcionario(); // Puxando atributos de funcionarios da classe (Funcionario);

            Console.WriteLine("Informe abaixo os dados do funcionário: ");
            Console.Write("Nome: ");
            f.NomeFuncionario = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcent); 
            Console.WriteLine("Dados atualizados: " + f);




        }
    }
}
