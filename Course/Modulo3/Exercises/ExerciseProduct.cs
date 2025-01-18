using Course.Modulo2.ClassesDosExercícios;
using Course.Modulo3.Class;
using System.Globalization;

namespace Course.Modulo3.Exercises
{
    internal class ExerciseProduct
    {
        // Iremos abordar um exemplo de vetor com objeto de referência. No caso, o produto é um todo e iremos calcular e utilzar um pouco de lógica
        // Para cadenciar e tratar o vetor de uma forma um pouco mais complexa, utilizando também uma classe externa, "ProductModuloTres".
        static void ExampleVectReference(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");

           int n = int.Parse(Console.ReadLine());

            ProductModuloTres[] vect = new ProductModuloTres[n]; // diferente do exemplo passado, desta vez, Product já está sendo referenciado como classe,
                                             // no outro, utilizamos valores para iniciar o vetor double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new ProductModuloTres { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {

                sum += vect[i].Price; // buscar somente o valor do vetor, deixando o nome de lado, pelo menos na hora da soma
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

