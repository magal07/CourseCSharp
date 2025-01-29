using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;

namespace Course
{
    internal class ProgramComparison
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            /* MODEL 1 
            Comparison<Product> comp = CompareProducts; // Comparison = variavel que guarda a referência para a função
            // depois passo a referência "comp" como argumento para a função sort abaixo 
            list.Sort(comp);*/
            /* LAMBDA EXEMPLO 1 MAIS ORGANIZADO: 
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); // <-- TUDO DECLARADO DE FORMA ABSTRATA
            

            //list.Sort(CompareProducts);*/  // ordenar -- delegate! = CompareProducts typeSafe

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // OUTRA FORMA LAMBDA, DENTRO DA REFERÊNCIA

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        /* AO INVÉS DE USAR ISTO: 
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        } 
    } */
    }
}
