using System.Collections.Generic;
using BankDepositsSystem.Enum;

namespace BankDepositsSystem.Entity
{
    class Client
    {
        public string Name { get; }
        public ClientStatus Status { get; }
        public bool IsHighCreditScore { get; }

        public List<Deposit> Deposits { get; set; }

        public Client(string name, ClientStatus status, bool isHighCreditScore)
        {
            Name = name;
            Status = status;
            IsHighCreditScore = isHighCreditScore;
        }
    }
}
