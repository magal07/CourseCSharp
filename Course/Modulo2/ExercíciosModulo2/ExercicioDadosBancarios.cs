using Course.Modulo1.Conteudo;
using Course.Modulo2.ClassesEMetodosDosExercícios;
using System.Globalization;

namespace Course.Modulo2.ExercíciosModulo2
{
    internal class ExercicioDadosBancarios
    {
        static void Main(string[] args)
        {
            DadosBancarios conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) : ");
            char resp = char.Parse(Console.ReadLine());
            {
                if(resp == 's' || resp == 'S' || resp == 'y' || resp == 'Y')
                {
                    Console.Write("Entre o valor de depósito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new DadosBancarios(numero, titular, depositoInicial);
                }
                else
                {
                    conta = new DadosBancarios(numero, titular);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.Write(conta);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("Para efetuar novas transações, retorne ao início do programa.");
        }
    }
}
