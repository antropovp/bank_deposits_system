using System.Windows;
using BankDepositsSystem.Entity;
using BankDepositsSystem.Enum;
using BankDepositsSystem.Repository;
using BankDepositsSystem.Repository.Implementation;

namespace BankDepositsSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IClientRepository ClientRepository { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ClientRepository = new ClientRepository();

            #region Test

            Client joe = new Client("Joe", ClientStatus.REGULAR, false);
            ClientRepository.Add(joe);
            Client empanadita = new Client("Steph", ClientStatus.CORPORATE, true);
            ClientRepository.Add(empanadita);
            empanadita.Deposits.Add(new Deposit(true, 14.5, 10_000));

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
