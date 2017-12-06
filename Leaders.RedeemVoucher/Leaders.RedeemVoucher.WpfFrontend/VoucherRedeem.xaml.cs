using System.Windows;
using System.Windows.Input;
using Leaders.RedeemVoucher.App.Interfaces;

namespace Leaders.RedeemVoucher.WpfFrontend
{
    /// <summary>
    /// Interaction logic for VoucherRedeem.xaml
    /// </summary>
    public partial class VoucherRedeem : Window
    {
        private readonly IVoucherAppService AppService;
        public VoucherRedeem(IVoucherAppService appService)
        {
            AppService = appService;
            InitializeComponent();
        }

        private void Minimize(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
