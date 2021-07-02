using System;

namespace BankDepositsSystem.Entity
{
    public class Loan
    {
        public DateTime DateOfCreation { get; }

        public string DateOfCreationWithoutTime_Text => DateOfCreation.ToString("dd/MM/yyyy");

        public Client Owner { get; }
        public string Name { get; set; }
        public bool IsCapitalized { get; }
        public double AnnualInterest { get; }
        public double InitialAmount { get; }
        public double CurrentAmount { get; set; }

        public Loan(Client owner, string name, bool isCapitalized, double annualInterest, double amount)
        {
            DateOfCreation = DateTime.Now;
            Owner = owner;
            Name = name;
            IsCapitalized = isCapitalized;
            AnnualInterest = annualInterest;
            InitialAmount = amount;
        }
    }
}