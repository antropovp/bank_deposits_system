using System.Collections.ObjectModel;
using BankDepositsSystem.Entity;
using BankDepositsSystem.Repository;

namespace BankDepositsSystem.Service.Implementation
{
    public class DepositService : IDepositService
    {
        public Deposit OpenDeposit(Client owner, string name, bool isCapitalized, double annualInterest, double amount)
        {
            Deposit newDeposit = new Deposit(owner, name, isCapitalized, annualInterest, amount);

            owner.Deposits.Add(newDeposit);

            return newDeposit;
        }

        public ObservableCollection<Deposit> GetAllDeposits(IClientRepository clientRepository)
        {
            ObservableCollection<Deposit> deposits = new ObservableCollection<Deposit>();

            foreach (Client client in clientRepository.Clients)
            {
                foreach (Deposit deposit in client.Deposits)
                {
                    deposits.Add(deposit);
                }
            }

            return deposits;
        }
    }
}