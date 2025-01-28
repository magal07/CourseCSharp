using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Course.Services
{
    // A classe PaypalService implementa a interface IOnlinePaymentService, oferecendo um serviço de pagamento
    // com taxa fixa de pagamento e juros mensais específicos. Ela calcula os juros e as taxas para as parcelas de um contrato.
    class PaypalService : IOnlinePaymentService
    {
        // Definindo constantes para a porcentagem da taxa de pagamento e para o valor do juros mensal.
        private const double FeePercentage = 0.02;   // Taxa de pagamento de 2%.
        private const double MonthlyInterest = 0.01; // Juros de 1% ao mês.

        // O método Interest calcula os juros sobre o valor da parcela com base no número de meses.
        // O cálculo é feito multiplicando o valor pela taxa de juros mensal e somando o número de meses.
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest + months;
        }

        // O método PaymentFee calcula a taxa de pagamento com base no valor da parcela.
        // A taxa é calculada multiplicando o valor pela constante FeePercentage (2%).
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
