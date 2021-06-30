namespace BankDepositsSystem.Entity
{
    public class Deposit
    {
        public bool isCapitalized { get; }
        public double annualInterest { get; }
        public double amount { get; }

        public Deposit(bool isCapitalized, double annualInterest, double amount)
        {
            this.isCapitalized = isCapitalized;
            this.annualInterest = annualInterest;
            this.amount = amount;
        }
    }
}
