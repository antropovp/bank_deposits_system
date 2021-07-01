using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace BankDepositsSystem
{
    /// <summary>
    /// Логика взаимодействия для OpenDepositWindow.xaml
    /// </summary>
    public partial class OpenDepositWindow : Window
    {
        private static readonly Regex _regex = new("[^0-9._]+");

        public OpenDepositWindow()
        {
            InitializeComponent();
        }

        public void ValidateInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = _regex.IsMatch(e.Text);
        }

        private void OpenDepositBtn_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
