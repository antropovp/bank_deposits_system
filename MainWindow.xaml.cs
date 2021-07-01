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
        public IClientRepository ClientRepository { get; set; }
        public IClientService ClientService { get; set; }
        public IDepositService DepositService { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ClientRepository = new ClientRepository();
            ClientService = new ClientService();
            DepositService = new DepositService();

            #region Test

            ClientService.AddClient(ClientRepository, "Joe", ClientType.REGULAR, false);

            Client empanadita = ClientService.AddClient(ClientRepository, "Steph", ClientType.CORPORATE, true);
            DepositService.OpenDeposit(empanadita, "BBVA deposit", true, 14.5, 10_000);

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

        private void OpenDepositBtn_OnClick(object sender, RoutedEventArgs e)
        {
            OpenDepositWindow openDepositWindow = new OpenDepositWindow();
            openDepositWindow.Show();
        }

        private void CloseDepositBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (ClientTreeView.SelectedItem.GetType() != typeof(Deposit)) return;

            Deposit depositToBeClosed = ClientTreeView.SelectedItem as Deposit;
            DepositService.CloseDeposit(depositToBeClosed);
        }

        private void TestBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
