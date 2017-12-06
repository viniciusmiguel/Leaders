using Leaders.RedeemVoucher.App.Interfaces;
using Leaders.RedeemVoucher.App.Services;
using Leaders.RedeemVoucher.Domain.Interfaces.Repositories;
using Leaders.RedeemVoucher.Domain.Interfaces.Services;
using Leaders.RedeemVoucher.Domain.Services;
using Leaders.RedeemVoucher.Infra.Repositories;
using SimpleInjector;

namespace Leaders.RedeemVoucher.Injector
{
    public static class DependencyInjection
    {
        private static Container Container;
        /// <summary>
        /// Inject Project Using Simple Injector
        /// </summary>
        public static void InjectBySimpleInjector()
        {
            if(Container != null) return;
            
            Container = new Container();

            Container.Register<IVoucherRepository, VoucherRepository>();
            Container.Register<IVoucherHistoricDataRepository, VoucherHistoricDataRepository>();

            Container.Register<IVoucherService, VoucherService>();
            Container.Register<IVoucherHistoricDataService, VoucherHistoricDataService>();

            Container.Register<IVoucherAppService,VoucherAppService>();
            Container.Verify();
        }
    }
}