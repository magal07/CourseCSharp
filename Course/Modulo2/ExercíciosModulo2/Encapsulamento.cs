using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Modulo2.ClassesDosExercícios;
using System.Globalization;

namespace Course.Modulo2.ExercíciosModulo2
{
    public class Encapsulamento
    {
        static void EncapsulamentoEstudo(string[] args)

        {
            Product p = new Product("TV", 500.00, 10);
            
            p.Name = "T";

            // p.Price = 100.95; <- Está privado e somente autoriza leitura, para alterar o preço, temos que ajustar o Set em Product;

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
           
        }
    }
}
