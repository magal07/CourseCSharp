using Course.ModuloDeEstudo.Modulo6.AccountBussines.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course.ModuloDeEstudo.Modulo6.AccountBussinesHeranca
{
    class Program
    {

        static void ProgramUsingAbstractInAccount(string[] args)
        {
            // somar todos os saldos 

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "André", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Bartolomeu", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Account account in list)
            {
                account.WithDraw(10.0);
            }
            foreach (Account account in list)
            {
                Console.WriteLine("Update balance for account "
                    + account.Number
                    + ": "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
