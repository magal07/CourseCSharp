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
      static void ExerciseProductStock(string[] args) 

        {
            Product p = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // Função adicionar 
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque:  ");
            int rem = int.Parse(Console.ReadLine());
            p.RemoverProdutos(rem);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }


    }
}
