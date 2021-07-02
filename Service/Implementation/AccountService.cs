using System.Collections.ObjectModel;
using BankDepositsSystem.Entity;
using BankDepositsSystem.Repository;

namespace BankDepositsSystem.Service.Implementation
{
    public class AccountService : IAccountService
    {
        public Account OpenAccount(Client owner, string name, bool isCapitalized, double annualInterest, double amount)
        {
            Account newAccount = new Account(owner, name, isCapitalized, annualInterest, amount);

            owner.Accounts.Add(newAccount);

            return newAccount;
        }

        public void CloseAccount(Account account)
        {
            account.Owner.Accounts.Remove(account);
            account = null;
        }

        public ObservableCollection<Account> GetAllAccounts(IClientRepository clientRepository)
        {
            ObservableCollection<Account> accounts = new ObservableCollection<Account>();

            foreach (Client client in clientRepository.Clients)
            {
                foreach (Account account in client.Accounts)
                {
                    accounts.Add(account);
                }
            }

            return accounts;
        }
    }
}