using System.Collections.ObjectModel;
using BankDepositsSystem.Entity;
using BankDepositsSystem.Repository;

namespace BankDepositsSystem.Service
{
    public interface IDepositService
    {
        Deposit OpenDeposit(Client owner, string name, bool isCapitalized, double annualInterest, double amount);

        void CloseDeposit(Deposit deposit);

        ObservableCollection<Deposit> GetAllDeposits(IClientRepository clientRepository);
    }
}