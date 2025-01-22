using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Course.ModulosDeEstudo.Modulo2.ClassesEMetodosDosExercícios;

namespace Course.ModulosDeEstudo.Modulo2.ExercíciosModulo2
{
    public class ExerciseProduct
    {
        static void ProductExercise(string[] args)

        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product p = new Product();

            Product p2 = new Product();
            /*
            Product p3 = new Product { 
                
                GetName = "TV",
                Price = 500.00, 
                Quantity = 20 };
                */

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p2);


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
