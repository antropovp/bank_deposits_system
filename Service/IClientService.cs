using BankDepositsSystem.Entity;
using BankDepositsSystem.Enum;
using BankDepositsSystem.Repository;

namespace BankDepositsSystem.Service
{
    public interface IClientService
    {
        Client AddClient(IClientRepository clientRepository, string name, ClientType type, bool isHighCreditScore);

        void RemoveClient(IClientRepository clientRepository, Client client);
    }
}