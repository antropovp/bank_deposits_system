using System;
using BankDepositsSystem.Entity;

namespace BankDepositsSystem.Service.Implementation
{
    public class TransactionService : ITransactionService
    {
        public void CreateTransaction(Account sender, Account receiver, double amount)
        {
            Transaction newTransaction = new Transaction(sender, receiver, amount);

            sender.CurrentAmount -= amount;
            receiver.CurrentAmount += amount;

            sender.Transactions.Add(newTransaction);
            receiver.Transactions.Add(newTransaction);
        }
    }
}