using BankDepositsSystem.Entity;
using BankDepositsSystem.Enum;
using BankDepositsSystem.Repository;

namespace BankDepositsSystem.Service.Implementation
{
    public class ClientService : IClientService
    {
        public Client AddClient(IClientRepository clientRepository, string name, ClientType type, bool isHighCreditScore)
        {
            Client newClient = new Client(name, type, isHighCreditScore);

            clientRepository.Add(newClient);

            return newClient;
        }
    }
}