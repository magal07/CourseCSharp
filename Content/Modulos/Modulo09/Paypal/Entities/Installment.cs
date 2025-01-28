using System;
using System.Globalization;

namespace Course.Entities
{
    // A classe Installment representa uma parcela de um contrato. 
    // Ela armazena a data de vencimento e o valor da parcela.
    internal class Installment
    {
        // Propriedade que armazena a data de vencimento da parcela.
        public DateTime DueDate { get; set; }

        // Propriedade que armazena o valor da parcela.
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;  
            Amount = amount;    
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")   
                + " - "                             
                + Amount.ToString("F2", CultureInfo.InvariantCulture); // Formata o valor da parcela com duas casas decimais.
        }
    }
}
