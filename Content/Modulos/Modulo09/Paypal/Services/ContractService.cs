using System;
using Course.Entities;

namespace Course.Services
{
    // A classe ContractService é responsável pelo processo de pagamento de um contrato.
    // Ela interage com a interface IOnlinePaymentService para aplicar juros e taxas nas parcelas do contrato.
    class ContractService
    {

        // A variável _onlinePaymentService armazena uma instância do serviço de pagamento online,
        // que será usado para calcular os juros e taxas das parcelas do contrato.
        private IOnlinePaymentService _onlinePaymentService;

        // O construtor da classe recebe uma implementação de IOnlinePaymentService, permitindo injeção de dependência.
        // Isso torna a classe flexível e permite que diferentes serviços de pagamento sejam utilizados.
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        // O método ProcessContract é responsável por processar o contrato e calcular as parcelas.
        // O valor total do contrato é dividido em parcelas mensais, e juros e taxas são aplicados a cada uma delas.
        public void ProcessContract(Contract contract, int months)
        {
            // Cálculo da quota básica: o valor total do contrato é dividido pelo número de meses.
            double basicQuota = contract.TotalValue / months;

            // Laço que itera sobre os meses do contrato (1 até o número de meses)
            for (int i = 1; i <= months; i++)
            {
                // Para cada parcela, a data é gerada somando 'i' meses à data inicial do contrato.
                DateTime date = contract.Date.AddMonths(i);

                // Cálculo da quota atualizada: aplica-se os juros sobre a quota básica.
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);

                // Cálculo da quota total: soma-se a taxa de pagamento à quota atualizada.
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);

                // Adiciona a parcela ao contrato com a data e o valor total calculado.
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
