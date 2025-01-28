using Course.ModuloDeEstudo.Modulo6.AccountBussines.Entities;
using System.Globalization;


namespace Course.ModuloDeEstudo.Modulo6.AccountBussines
{
    internal class ProgramAccount
    {
        static void AccountProgram(string[] args)
        {

            Account acc = new Account(1001, "Marcelo", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);


            // UPCASTING 

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Bob", 0.0, 0.01);

            // DOWNCASTING = Usar somente quando for muito necessário

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3; // aqui da erro pois o acc3 tá como SavingsAccount
            // desta forma podemos testar pra verificar falhas no código, logo o exemplo abaixo vai dar false porém vai continuar rodando o program

            if (acc3 is BusinessAccount) // is = é (leitura: se o acc3 é uma instância de BusinessAccount, execute = 
            {

                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // modelo alternativo de sintaxe
                    acc5.Loan(200.0);
                    Console.WriteLine("Loan!");
                }

                if (acc3 is SavingsAccount)
                {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; // modelo alternativo de sintaxe
                acc5.UpdateBalance();
                    Console.WriteLine("Update!");
                }   
            }
        }
    }

