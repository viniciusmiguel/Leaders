using System.Windows;
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
        public MainWindow(IVoucherAppService appService)
        {
            AppService = appService;
            ViewModel = new AddEditVoucherViewModel();
            this.DataContext = ViewModel;
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
