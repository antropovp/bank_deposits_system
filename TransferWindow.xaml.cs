using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace BankDepositsSystem
{
    /// <summary>
    /// Логика взаимодействия для TransferWindow.xaml
    /// </summary>
    public partial class TransferWindow : Window
    {
        private static readonly Regex _regex = new("[^0-9._]+");

        public TransferWindow()
        {
            InitializeComponent();

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            ClientTreeView.ItemsSource = mainWindow.ClientRepository.Clients;
            DepositBox.ItemsSource = mainWindow.DepositService.GetAllDeposits(mainWindow.ClientRepository);
        }

        public void ValidateInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = _regex.IsMatch(e.Text);
        }

        private void TransferBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}