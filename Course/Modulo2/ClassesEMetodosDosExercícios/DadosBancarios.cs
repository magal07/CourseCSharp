using Course.Modulo1.Conteudo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo2.ClassesEMetodosDosExercícios
{
    internal class DadosBancarios
    {

        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }

        public double Saldo { get; private set; }


        public DadosBancarios(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public DadosBancarios(int numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta)
        {
            Deposito(depositoInicial);
            while (depositoInicial <= 0)
            {
                Console.Write("Você precisa digitar um valor maior que 0 para o primeiro depósito: R$ ");
                depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            Deposito(depositoInicial); Console.WriteLine("Parabéns pelo seu primeiro depósito :)");

        }






public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + TitularConta
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
