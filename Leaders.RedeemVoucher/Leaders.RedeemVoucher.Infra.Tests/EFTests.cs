using Leaders.RedeemVoucher.Infra.DbContext;
using Leaders.RedeemVoucher.Infra.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leaders.RedeemVoucher.Infra.Tests
{
    [TestClass]
    public class EFTests
    {
        [TestMethod]
        public void ContextTest()
        {
            var context = new SqlServerContext();
            Assert.IsInstanceOfType(context,typeof(SqlServerContext),"Not a valid instance of SqlServerContext");
        }
        [TestMethod]
        public void VoucherRepositoryInstanceTest()
        {
            var repo = new VoucherRepository();
            Assert.IsInstanceOfType(repo, typeof(VoucherRepository),"Invalid instance of VoucherRepository");
        }
        [TestMethod]
        public void VoucherHistoricDataRepositoryInstanceTest()
        {
            var repo = new VoucherHistoricDataRepository();
            Assert.IsInstanceOfType(repo, typeof(VoucherHistoricDataRepository), "Invalid instance of VoucherHistoricDataRepository");
        }
        
        [TestMethod]
        public void VoucherRepositoryQueryTest()
        {
            var repo = new VoucherRepository();
            var result = repo.GetAll();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void VoucherHistoricDataRepositoryQueryTest()
        {
            var repo = new VoucherHistoricDataRepository();
            var result = repo.GetAll();
            Assert.IsNotNull(result);
        }
    }
}
