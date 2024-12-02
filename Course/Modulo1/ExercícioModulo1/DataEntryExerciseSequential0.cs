using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo1.ExercícioModulo1
{
    public class DataEntryExerciseSequential0
    {
        static void ExercicioEstruturaSequencial1(string[] args)
        {

            string nome1 = Console.ReadLine();
            int quarto1 = int.Parse(Console.ReadLine());
            double produto1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            string[] House = Console.ReadLine().Split(' ');

            string sobrenome = House[0];
            int idade = int.Parse(House[1]);
            double altura = double.Parse(House[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome completo: ");
            Console.WriteLine(nome1);
            Console.WriteLine("Quantos quartos tem na sua casa?: ");
            Console.WriteLine(quarto1);
            Console.WriteLine("Entre com o preço do produto: ");
            Console.WriteLine(produto1.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
