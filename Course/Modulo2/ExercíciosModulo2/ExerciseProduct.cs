using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Modulo2.ClassesDosExercícios;
using System.Globalization;

namespace Course.Modulo2.ExercíciosModulo2
{
    public class ExerciseProduct
    {
      static void Main(string[] args) 

        {
            Product p = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque:");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

        }


    }
}
