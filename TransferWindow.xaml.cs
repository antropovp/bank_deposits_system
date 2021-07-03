using System;
using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;
using BankDepositsSystem.Entity;

namespace BankDepositsSystem
{
    /// <summary>
    /// Логика взаимодействия для TransferWindow.xaml
    /// </summary>
    public partial class TransferWindow : Window
    {
        private static readonly Regex _regex = new("[^0-9._]+");
        private readonly MainWindow mainWindow;

        public TransferWindow()
        {
            InitializeComponent();
            mainWindow = Application.Current.MainWindow as MainWindow;

            ClientTreeView.ItemsSource = mainWindow.ClientRepository.Clients;
            AccountBox.ItemsSource = mainWindow.AccountService.GetAllAccounts(mainWindow.ClientRepository);
        }

        public void ValidateInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = _regex.IsMatch(e.Text);
        }

        private void TransferBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (AccountBox.SelectionBoxItem.GetType() != typeof(Account)) return;
            if (ClientTreeView.SelectedItem.GetType() != typeof(Account)) return;

            mainWindow.TransactionService.CreateTransaction(AccountBox.SelectionBoxItem as Account,
                ClientTreeView.SelectedItem as Account, Convert.ToDouble(TransferAmountBox.Text));
        }
    }
}