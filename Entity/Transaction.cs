namespace BankDepositsSystem.Entity
{
    public class Transaction
    {
        public Account Sender { get; }
        public Account Receiver { get; }
        public double Amount { get; }

        public Transaction(Account sender, Account receiver, double amount)
        {
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
        }
    }
}