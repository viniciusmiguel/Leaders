using System;
using Leaders.RedeemVoucher.Injector;

namespace Leaders.RedeemVoucher.WpfFrontend
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var di = new DependencyInjection();
            di.InjectBySimpleInjector();
            di.RegisterWpfWindow<MainWindow>();
            di.RegisterWpfWindow<VoucherRedeem>();
            if(! di.Verify()) return;
            
            var app = new App();
            var mainWindow = di.GetInstance<MainWindow>();
            app.Run(mainWindow);
        }
    }
}
