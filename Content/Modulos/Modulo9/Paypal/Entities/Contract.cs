using Course.Services;
using System;
using System.Collections.Generic;

namespace Course.Entities
{

    internal class Contract : PaypalService
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; }

        // A lista de parcelas é inicializada vazia, pronta para receber as parcelas posteriormente.
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;         
            Date = date;             
            TotalValue = totalValue; 
            Installments = new List<Installment>(); // Inicializa a lista de parcelas
        }

        // Método para adicionar uma nova parcela ao contrato.
        // A nova parcela é passada como parâmetro e é adicionada à lista de parcelas.
        public void AddInstallment(Installment installMent)
        {
            Installments.Add(installMent);
        }
    }
}
