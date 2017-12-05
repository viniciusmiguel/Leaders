using Leaders.RedeemVoucher.Domain.Entities;

namespace Leaders.RedeemVoucher.Domain.Interfaces.Repositories
{
    public interface IVoucherHistoricDataRepository: IRepositoryBase<VoucherHistoricData>
    {
        VoucherHistoricData GetByVoucherNo(string voucherNo);
    }
}