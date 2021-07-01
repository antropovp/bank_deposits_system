using System;

namespace BankDepositsSystem.Entity
{
    public class Deposit
    {
        public DateTime DateOfCreation { get; }
        public Client Owner { get; }
        public string Name { get; set; }
        public bool IsCapitalized { get; }
        public double AnnualInterest { get; }
        public double Amount { get; set; }

        public Deposit(Client owner, string name, bool isCapitalized, double annualInterest, double amount)
        {
            DateOfCreation = DateTime.Now;
            Owner = owner;
            Name = name;
            IsCapitalized = isCapitalized;
            AnnualInterest = annualInterest;
            Amount = amount;
        }
    }
}
