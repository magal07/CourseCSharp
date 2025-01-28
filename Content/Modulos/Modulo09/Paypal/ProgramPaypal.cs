using System;
using System.Globalization;
using Course.Entities; // Importa as entidades do projeto
using Course.Services; // Importa os serviços do projeto

namespace Course
{
    class Program
    {
        static void ContractServices(string[] args)
        {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture); // Lê a data digitada e converte para DateTime usando formato específico

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine()); 

            // Cria um novo contrato com os dados fornecidos
            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            // Instancia o serviço de contrato e define o serviço de pagamento online a ser utilizado
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months); // Processa o contrato gerando as parcelas

            // Exibe as parcelas calculadas no contrato
            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment); // Exibe cada parcela gerada
            }
        }
    }
}
