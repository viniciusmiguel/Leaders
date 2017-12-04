using System.Data.Entity;

namespace Leaders.RedeemVoucher.Infra.DbContext
{
    public class SqlServerContext : System.Data.Entity.DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}