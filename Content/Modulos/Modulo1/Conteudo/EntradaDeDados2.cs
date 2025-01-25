using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Course.ModulosDeEstudo.Modulo1.Conteudo
{
    class EntradaDeDados2
    {
        static void DataEntry(string[] args)
        {
            /* FORMA 1 DE FAZER 
            string nome = Console.ReadLine();
            char ch = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // GLOBALIZATION! 

            Console.WriteLine();
            Console.WriteLine("Nome: ");
            Console.WriteLine(nome);
            Console.WriteLine("Gênero: ");
            Console.WriteLine(ch);
            Console.WriteLine("Idade: ");
            Console.WriteLine(n1);
            Console.WriteLine("Altura: ");
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); */

            // COM VETORES // 

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // GLOBALIZATION! 

            string[] cadastro = Console.ReadLine().Split(' ');

            //Console.WriteLine("Nome: ");
            string nome = cadastro[0];
            //Console.WriteLine("Gênero: ");
            char genero = char.Parse(cadastro[1]);
            //Console.WriteLine("Idade: ");
            int idade = int.Parse(cadastro[2]);
            // Console.WriteLine("Altura: ");
            double altura = double.Parse(cadastro[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Nome: ");
            Console.WriteLine(nome);
            Console.WriteLine("Gênero: ");
            Console.WriteLine(genero);
            Console.WriteLine("Idade: ");
            Console.WriteLine(idade);
            Console.WriteLine("Altura: ");
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
