using System.Windows;
using BankDepositsSystem.Entity;
using BankDepositsSystem.Enum;
using BankDepositsSystem.Repository;
using BankDepositsSystem.Repository.Implementation;
using BankDepositsSystem.Service;
using BankDepositsSystem.Service.Implementation;

namespace BankDepositsSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IClientRepository ClientRepository { get; }
        public IClientService ClientService { get; }
        public IAccountService AccountService { get; }
        public ITransactionService TransactionService { get; }

        public MainWindow()
        {
            InitializeComponent();
            ClientRepository = new ClientRepository();
            ClientService = new ClientService();
            AccountService = new AccountService();
            TransactionService = new TransactionService();

            #region Test

            ClientService.AddClient(ClientRepository, "Joe", ClientType.REGULAR, false);

            Client empanadita = ClientService.AddClient(ClientRepository, "Steph", ClientType.CORPORATE, true);
            AccountService.OpenAccount(false, empanadita, "BBVA deposit", true, 14.5, 10_000);

            #endregion

            ClientTreeView.ItemsSource = ClientRepository.Clients;
        }

        private void AddClientBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.Show();
        }

        private void DeleteClientBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (ClientTreeView.SelectedItem.GetType() != typeof(Client)) return;
            
            Client clientToBeDeleted = ClientTreeView.SelectedItem as Client;
            ClientService.RemoveClient(ClientRepository, clientToBeDeleted);
        }

        private void TransferBtn_OnClick(object sender, RoutedEventArgs e)
        {
            TransferWindow transferWindow = new TransferWindow();
            transferWindow.Show();
        }

        private void AccountInfoBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OpenAccountBtn_OnClick(object sender, RoutedEventArgs e)
        {
            OpenAccountWindow openAccountWindow = new OpenAccountWindow();
            openAccountWindow.Show();
        }

        private void CloseAccountBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (ClientTreeView.SelectedItem.GetType() != typeof(Account)) return;

            Account accountToBeClosed = ClientTreeView.SelectedItem as Account;
            AccountService.CloseAccount(accountToBeClosed);
        }

        private void TestBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
