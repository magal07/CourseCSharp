using Course.ModuloDeEstudo.Modulo6.AccountBussines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModuloDeEstudo.Modulo6.AccountBussines
{
    internal class ProgramHeranceBusinessAccount
    {
        static void AccountBusinessHeranca(string[] args)
        {
            Account acc1 = new Account(1000, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance); // saque com taxa por ser comum
            Console.WriteLine(acc2.Balance); // saque sem taxa de saque por ser poupança
        }
    }
}
