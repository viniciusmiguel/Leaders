using Leaders.RedeemVoucher.Domain.Entities;

namespace Leaders.RedeemVoucher.Domain.Interfaces.Repositories
{
    public interface IVoucherRepository : IRepositoryBase<Voucher>
    {
        Voucher GetByVoucherNo(string voucherNo);
    }
}