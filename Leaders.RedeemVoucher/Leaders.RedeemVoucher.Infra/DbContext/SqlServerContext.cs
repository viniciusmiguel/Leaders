using Leaders.RedeemVoucher.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leaders.RedeemVoucher.Infra.DbContext
{
    public class SqlServerContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS;Integrated Security=SSPI;" +
                "database = sam4windb;" +
                "User Instance = false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voucher>().ToTable("tvoucher");
            modelBuilder.Entity<VoucherHistoricData>().ToTable("tvoucherhis");
        }

    }
}