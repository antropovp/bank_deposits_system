using System.Collections.ObjectModel;
using BankDepositsSystem.Entity;
using BankDepositsSystem.Repository;

namespace BankDepositsSystem.Service
{
    public interface IAccountService
    {
        Account OpenAccount(Client owner, string name, bool isCapitalized, double annualInterest, double amount);

        void CloseAccount(Account account);

        ObservableCollection<Account> GetAllAccounts(IClientRepository clientRepository);
    }
}