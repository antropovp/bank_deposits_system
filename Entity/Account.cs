using System;
using System.Collections.ObjectModel;

namespace BankDepositsSystem.Entity
{
    public class Account
    {
        public DateTime DateOfCreation { get; }
        public ObservableCollection<Transaction> Transactions { get; set; }

        public string DateOfCreationWithoutTime_Text => DateOfCreation.ToString("dd/MM/yyyy");

        public Client Owner { get; }
        public string Name { get; set; }
        public bool IsCapitalized { get; }
        public double AnnualInterest { get; }
        public double CurrentAmount { get; set; }

        public Account(Client owner, string name, bool isCapitalized, double annualInterest, double amount)
        {
            DateOfCreation = DateTime.Now;
            Transactions = new ObservableCollection<Transaction>();

            Owner = owner;
            Name = name;
            IsCapitalized = isCapitalized;
            AnnualInterest = annualInterest;
            CurrentAmount = amount;
        }
    }
}
