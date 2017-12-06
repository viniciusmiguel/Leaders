using System.Windows;
using Leaders.RedeemVoucher.App.Interfaces;

namespace Leaders.RedeemVoucher.WpfFrontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IVoucherAppService AppService;
        public MainWindow(IVoucherAppService appService)
        {
            AppService = appService;
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
