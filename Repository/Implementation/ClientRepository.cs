using System.Collections.ObjectModel;
using BankDepositsSystem.Entity;
using BankDepositsSystem.Enum;

namespace BankDepositsSystem.Repository.Implementation
{
    public class ClientRepository : IClientRepository
    {
        public ObservableCollection<Client> Clients { get; set; }

        public ClientRepository()
        {
            Clients = new ObservableCollection<Client>();
        }

        public void Add(Client client)
        {
            Clients.Add(client);
        }

        public void Add(ObservableCollection<Client> clients)
        {
            foreach (Client client in clients)
            {
                Clients.Add(client);
            }
        }

        public void Remove(Client client)
        {
            Clients.Remove(client);
        }

        public void Remove(ObservableCollection<Client> clients)
        {
            foreach (Client client in clients)
            {
                Clients.Remove(client);
            }
        }
    }
}