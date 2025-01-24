
namespace Course.ModuloDeEstudo.Modulo6.AccountBussines.Entities
{
    class BusinessAccount : Account // Conta de empresa irá herdar por completo a CLASSE CONTA
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            :  base(number, holder, balance)  // Buscando e implementando a base do Account
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
