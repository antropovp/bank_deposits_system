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

        private void OpenDepositBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CloseDepositBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void AddClientBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void DeleteClientBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void TestBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SendTransferBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
