using System.Globalization;

namespace Course.Modulo3.Exercises

{
    class ExericseHigh
    {
        static void HIghExercise(string[] args)
        {
            Console.Write("Informe quantos vetores serão: ");
            int n = int.Parse(Console.ReadLine());

            // Abaixo iremos criar 1 vetor sem quantitativo, pois ele será definido pela variável "n" informada acima.

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }
            double media = soma / n;

            Console.WriteLine("AVERAGE HEIGHT: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
