using System;
using System.Globalization; // Necessário para usar o CultureInfo.InvariantCulture

namespace Course.Modulo1.ExercícioModulo1.ForExercises
{
    internal class ExerciseThreeFor
    {
        static void Exercise3For(string[] args)
        {

            /* 
            // Lê o número de casos de teste (quantas médias devem ser calculadas)
            int n = int.Parse(Console.ReadLine());

            // Loop em FOR para calcular a média ponderada de cada caso de teste
            for (int i = 0; i < n; i++)
            {
                
                string[] line = Console.ReadLine().Split(' ');

                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                // Calcule a média ponderada: 
                // - Primeiro número tem peso 2
                // - Segundo número tem peso 3
                // - Terceiro número tem peso 5

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0; // - Soma os pesos (2 + 3 + 5 = 10) e divide a soma ponderada por 10

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture)); */
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                // Calcula a média ponderada
                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                // Verifica se a média está acima de 5
                if (media >= 6.5)
                {
                    Console.WriteLine("Você passou nesta disciplina, sua média é = " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Você repetiu nesta disciplina, sua média foi = " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
                
            }
        }
    }
}
