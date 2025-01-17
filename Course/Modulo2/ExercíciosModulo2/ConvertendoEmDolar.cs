using System.Globalization;
using Course.Metodos;

namespace Course.Modulo2.ExercíciosModulo2
{
    public class ConvertendoEmDolar
    {
        static void ConversaoRealParaDolar(string[] args)
        {


            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Calculadora.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
