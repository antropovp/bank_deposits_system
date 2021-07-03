using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace BankDepositsSystem
{
    /// <summary>
    /// Логика взаимодействия для DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow()
        {
            InitializeComponent();

            MessageIcon.Source = Imaging.CreateBitmapSourceFromHIcon(SystemIcons.Exclamation.Handle, Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
        }
    }
}
