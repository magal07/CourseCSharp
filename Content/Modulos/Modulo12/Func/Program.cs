using Course.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();


            list.Add(new Product("TV,", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //List<string> result = list.Select(NameUpper).ToList(); // to.list convertendo o IEnumerable para list; MODO 1

            //Func<Product, string> func = NameUpper; ; // MODO 2 USANDO Func com até 16 expressões

            //Func<Product, string> func = p => p.Name.ToUpper(); // LAMBDA EXEMPLO 1

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); // LAMBDA AJUSTADA AO MÉTODO <- VERSÃO FINAL


            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
