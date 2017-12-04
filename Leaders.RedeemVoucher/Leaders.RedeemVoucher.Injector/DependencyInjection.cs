using SimpleInjector;

namespace Leaders.RedeemVoucher.Injector
{
    public static class DependencyInjection
    {
        private static Container Container;
        static void InjectBySimpleInjector()
        {
            Container = new Container();

            Container.Verify();
        }
    }
}