namespace BankDepositsSystem.Entity
{
    public class Deposit
    {
        public bool IsCapitalized { get; }
        public double AnnualInterest { get; }
        public double Amount { get; }

        public Deposit(bool isCapitalized, double annualInterest, double amount)
        {
            IsCapitalized = isCapitalized;
            AnnualInterest = annualInterest;
            Amount = amount;
        }
    }
}
