using System.Collections.ObjectModel;
using BankDepositsSystem.Entity;

namespace BankDepositsSystem.Repository.Implementation
{
    public class Repository : IRepository
    {
        public ObservableCollection<Client> Clients { get; set; }

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