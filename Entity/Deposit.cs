using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDepositsSystem.Entity
{
    class Deposit
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
