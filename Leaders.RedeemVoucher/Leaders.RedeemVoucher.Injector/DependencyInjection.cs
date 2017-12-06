using System;
using Leaders.RedeemVoucher.App.Interfaces;
using Leaders.RedeemVoucher.App.Services;
using Leaders.RedeemVoucher.Domain.Interfaces.Repositories;
using Leaders.RedeemVoucher.Domain.Interfaces.Services;
using Leaders.RedeemVoucher.Domain.Services;
using Leaders.RedeemVoucher.Infra.Repositories;
using SimpleInjector;

namespace Leaders.RedeemVoucher.Injector
{
    public class DependencyInjection
    {
        private Container Container;
        /// <summary>
        /// Inject Project Using Simple Injector
        /// </summary>
        public void InjectBySimpleInjector()
        {
            if(Container != null) return;
            
            Container = new Container();

            Container.Register<IVoucherRepository, VoucherRepository>();
            Container.Register<IVoucherHistoricDataRepository, VoucherHistoricDataRepository>();

            Container.Register<IVoucherService, VoucherService>();
            Container.Register<IVoucherHistoricDataService, VoucherHistoricDataService>();

            Container.Register<IVoucherAppService,VoucherAppService>();
        }

        public void RegisterWpfWindow<T>() where T : class 
        {
            Container.Register<T>();
        }
        public T GetInstance<T>() where T : class
        {
            return Container.GetInstance<T>();
        }

        public bool Verify()
        {
            try
            {
                Container.Verify();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
    }
}