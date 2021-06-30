using System.Collections.Generic;
using System.Collections.ObjectModel;
using BankDepositsSystem.Enum;

namespace BankDepositsSystem.Entity
{
    public class Client
    {
        public string Name { get; }
        public ClientStatus Status { get; }
        public bool IsHighCreditScore { get; }

        public ObservableCollection<Deposit> Deposits { get; set; }

        public Client(string name, ClientStatus status, bool isHighCreditScore)
        {
            Name = name;
            Status = status;
            IsHighCreditScore = isHighCreditScore;
        }
    }
}
