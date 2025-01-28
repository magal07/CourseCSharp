namespace Course.Services
{
    // A interface IOnlinePaymentService define os métodos que qualquer serviço de pagamento online deve implementar.
    // Ela tem dois métodos: PaymentFee e Interest, responsáveis por calcular a taxa de pagamento e os juros de um valor, respectivamente.
    interface IOnlinePaymentService
    {

        // O método PaymentFee calcula a taxa de pagamento aplicada ao valor de uma parcela.
        // Ele recebe um valor e retorna o valor da taxa de pagamento.
        double PaymentFee(double amount);

        // O método Interest calcula os juros aplicados a um valor, levando em consideração o número de meses.
        // Ele recebe o valor da parcela e o número de meses e retorna o valor dos juros.
        double Interest(double amount, int months);
    }
}
