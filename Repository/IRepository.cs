﻿using System.Collections.ObjectModel;
using BankDepositsSystem.Entity;

namespace BankDepositsSystem.Repository
{
    public interface IRepository
    {
        void Add(Client client);
        void Add(ObservableCollection<Client> clients);

        void Remove(Client client);
        void Remove(ObservableCollection<Client> clients);
    }
}