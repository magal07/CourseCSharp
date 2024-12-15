using System;
using System.Globalization; // Necessário para usar o CultureInfo.InvariantCulture

namespace Course.Modulo1.ExercícioModulo1
{
    internal class ExerciseThreeFor
    {
        static void Exercise2ForCalculationAvarage(string[] args)
        {
            // Lê o número de casos de teste (quantas médias devem ser calculadas)
            int n = int.Parse(Console.ReadLine());

            // Loop para calcular a média ponderada de cada caso de teste
            for (int i = 0; i < n; i++)
            {
                // Lê uma linha contendo 3 números separados por espaço e os divide em um array
                string[] line = Console.ReadLine().Split(' ');

                // Converte o primeiro número da linha para double, utilizando ponto como separador decimal
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);

                // Converte o segundo número da linha para double
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);

                // Converte o terceiro número da linha para double
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                // Calcula a média ponderada: 
                // - Primeiro número tem peso 2
                // - Segundo número tem peso 3
                // - Terceiro número tem peso 5
                // - Soma os pesos (2 + 3 + 5 = 10) e divide a soma ponderada por 10
                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                // Exibe o resultado com uma casa decimal, usando ponto como separador
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
