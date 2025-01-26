using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Course.Entities;
using System.Security.AccessControl;
using Course.Exceptions;


namespace Course
{
    internal class ProgramAccountBalances
    {
        static void ProgramAccountBalance(string[] args)
        {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holderAccount = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balanceAccount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimitAccount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(numberAccount, holderAccount, balanceAccount, withdrawLimitAccount);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try 
            {
                acc.Withdraw(amount);
            }

            catch (DomainException e) {

                Console.Write("Withdraw error: " + e.Message);
            }
        }

    }
}
