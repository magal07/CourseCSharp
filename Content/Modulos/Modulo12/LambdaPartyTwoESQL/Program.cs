using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection) // criando função print
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {

                Console.WriteLine(obj);
                
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {

            new Product() { Id = 1, Name = "Computer", Price = 1100.00, Category = c2 }, // c2 = associando os dois objts Category and Product
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }

        };        // LAMBDA ABAIXO: todo produto p, tal que p.category.tier seja igual a 1 e p.price seja < q 900
            var r1 = products
                .Where(p => p.Category.Tier == 1 && p.Price < 900.0);
                Print("TIER 1 AND PRICE <900: ", r1);

            // alternativa model SQL

            var r1alt =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 AND PRICE < 900 ALTER", r1alt);

            // Filtra a lista de produtos (products), retornando apenas os que pertencem à categoria "Tools"
            var r2 = products
                .Where(p => p.Category.Name == "Tools") // Aplica um filtro para selecionar apenas os produtos da categoria "Tools"
                .Select(p => p.Name); // Seleciona apenas o nome dos produtos filtrados
            Print("NAMES OF PRODUCTS FROM TOOLS: ", r2); // neste caso, a concatenação é com "," e não "+"

            //Alternativa SQL

            var r2alt =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS: ", r2alt);



            var r3 = products
                // filtrando somente os que começam com a letra c
                .Where(p => p.Name[0] == 'C')
                // selecionando o que quero filtrar com select, no caso do category name, 
                                                  //  \/   tivemos que criar uma variável temporária por conta de  já ter um name nesta lambda
                .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); // 
            Print("Products initial letter C: ", r3);

            var r3alt =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("Products initial letter C: ", r3alt);


            var r4 = products
                .Where(p => p.Category.Tier == 1)
                // Ordene por PREÇO    e DEPOIS por NOME
                .OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);

            var r4alt =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4alt);


            var r5 = r4.Skip(2).Take(4); // pula os 2 primeiros e pega 4 elementos
            Print("Skip and Take: ", r5);

            var r5alt =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("Skip and Take: ", r5alt);


            var r6 = products.FirstOrDefault(); // FirstOrDefault: vai caçar o primeiro, se não achar, ele retorna NULL
            Console.WriteLine("First or Defaulttest1: " + r6);

            var r7 = products
                .Where(p => p.Price > 3000.00)
                .FirstOrDefault();
            Console.WriteLine("First Or Default teste2: " + r7);

            // alternativa

            var r7alt =
                (from p in products
                 where p.Price > 3000.00
                 select p).FirstOrDefault();
            Console.WriteLine("First Or Default teste2: " + r7alt);


            var r8 = products
                .Where(p => p.Id == 3)
                .SingleOrDefault(); // retornará somente 1 dado, ou NULL caso não exista
            Console.WriteLine("Single or Default teste1: " + r8);

            var r9 = products
                .Where(p => p.Id == 30)
                .SingleOrDefault(); // retornará NULL pos o ID não existe
            Console.WriteLine("Single or Default teste2: " + r9);

            var r10 = products
                .Max(p => p.Price); // solicita o valor máximo fornecido pela list
            Console.WriteLine("Max price: " + r10);

            var r11 = products
                .Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products
                .Where(p => p.Category.Id == 1)
                .Sum(p => p.Price); // somará todos os preços da categoria 1
            Console.WriteLine("Category 1 sum prices: " + r12);

            var r13 = products
                .Where(p => p.Category.Id == 1)
                .Average(p => p.Price); // verá a média de todos os preços da categoria 1
            Console.WriteLine("Category 1 average prices: " + r13);
            // solucionando um problema de exceção caso a categoria fosse inexistente exemplo r13 e r14
            var r14 = products
                .Where(p => p.Category.Id == 5) // Filtra produtos da categoria 5 (que não existe)
                .Select(p => (double?)p.Price) // Usa um tipo nullable para permitir valores nulos
                .DefaultIfEmpty(null) // Se não houver valores, retorna null
                .Average(); // Calcula a média
                                                         // Se a média for nula, exibe "Not value", caso contrário, exibe o valor
            Console.WriteLine("Category 5 average prices: " + (r14.HasValue ? r14.Value.ToString("F2") : "Not value"));
            // abaixo eu quem estou definindo os parâmetros que quero de calculos, neste exemplo, quis que o x e y somassem
            var r15 = products
                .Where(p => p.Category.Id == 1) 
                .Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); // colocamos o 0.0 como valor inicial pois assim ele não dá exceções e joga o valor para 0.0
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products
                .GroupBy(p => p.Category);
                foreach (IGrouping<Category, Product> group in r16) // percorendo cada elemento do meu resultado, e cada elemento é do tipo IGrouping<CHAVE, COLEÇÃO>
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

            var r16alt =
            from p in products
            group p by p.Category;

            foreach (IGrouping<Category, Product> group in r16) // percorendo cada elemento do meu resultado, e cada elemento é do tipo IGrouping<CHAVE, COLEÇÃO>
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}

