using System.Windows;
using System.Windows.Input;
using Leaders.RedeemVoucher.App.Interfaces;
using Leaders.RedeemVoucher.App.ViewModels;

namespace Leaders.RedeemVoucher.WpfFrontend
{
    /// <summary>
    /// Interaction logic for VoucherRedeem.xaml
    /// </summary>
    public partial class VoucherRedeem : Window
    {
        private readonly IVoucherAppService AppService;
        private VoucherRedeemViewModel ViewModel;
        public VoucherRedeem(IVoucherAppService appService)
        {
            AppService = appService;
            ViewModel = new VoucherRedeemViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }

        private void Minimize(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Maximize(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void VoucherKeyEvent(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;

            var message = AppService.LocateVoucher(ref ViewModel);
            if(message != null)
                MessageBox.Show(message);
        }

        private void RedeemVoucherClick(object sender, RoutedEventArgs e)
        {
            var message = AppService.TryToRedeemVoucher(ref ViewModel);
            if (message != null)
                MessageBox.Show(message);
        }
    }
}
