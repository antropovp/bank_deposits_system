using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace BankDepositsSystem
{
    /// <summary>
    /// Логика взаимодействия для TransferWindow.xaml
    /// </summary>
    public partial class TransferWindow : Window
    {
        public TransferWindow()
        {
            InitializeComponent();

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            ClientTreeView.ItemsSource = mainWindow.ClientRepository.Clients;
            DepositBox.ItemsSource = mainWindow.DepositService.GetAllDeposits(mainWindow.ClientRepository);
        }

        private void TransferBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
