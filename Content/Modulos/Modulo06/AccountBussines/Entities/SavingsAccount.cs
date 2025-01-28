using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModuloDeEstudo.Modulo6.AccountBussines.Entities
{
    sealed class SavingsAccount : Account // SEALED = NÃO PERMITE QUE NENHUMA OUTRA CLASSE HERDE-A.
        
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
                              : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void WithDraw(double amount) // SEALED = para métodos sobrepostos = não permite ter reuso de uma 3ª classe
        { // base, reaproveitar construtores ou pra chamar métodos comuns de superclasses
            base.WithDraw(amount); // efetuar o saque descontando 5 reais
            Balance -= 2.0; // retirar além do saque comum de 5 reais , - 2 reais.
        }
    }
}
