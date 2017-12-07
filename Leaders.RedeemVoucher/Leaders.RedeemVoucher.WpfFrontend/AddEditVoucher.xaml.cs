using System.Windows;
using System.Windows.Controls;
using Leaders.RedeemVoucher.App.Interfaces;
using Leaders.RedeemVoucher.App.ViewModels;

namespace Leaders.RedeemVoucher.WpfFrontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IVoucherAppService AppService;
        private AddEditVoucherViewModel ViewModel;
        private readonly VoucherRedeem VoucherRedeem;
        public MainWindow(IVoucherAppService appService, VoucherRedeem voucherRedeem)
        {
            AppService = appService;
            ViewModel = new AddEditVoucherViewModel();
            this.DataContext = ViewModel;
            InitializeComponent();
            AppService.GetVoucherList(ViewModel);
            VoucherRedeem = voucherRedeem;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void VoucherSelectorChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void RedeemClick(object sender, RoutedEventArgs e)
        {
            VoucherRedeem.Show();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
