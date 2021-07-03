using BankDepositsSystem.Entity;

namespace BankDepositsSystem.Service
{
    public interface ITransactionService
    {
        void CreateTransaction(Account sender, Account receiver, double amount);
    }
}