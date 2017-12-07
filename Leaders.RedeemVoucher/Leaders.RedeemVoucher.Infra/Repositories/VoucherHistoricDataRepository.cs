using Leaders.RedeemVoucher.Domain.Entities;
using Leaders.RedeemVoucher.Domain.Interfaces.Repositories;
using System.Linq;
namespace Leaders.RedeemVoucher.Infra.Repositories
{
    public class VoucherHistoricDataRepository : RepositoryBase<VoucherHistoricData>, IVoucherHistoricDataRepository
    {
        public VoucherHistoricData GetByVoucherNo(string voucherNo)
        {
            try
            {
                return (from voucher in GetAll() where voucher.VoucherNo == voucherNo select voucher).First();
            }
            catch
            {
                return null;
            }
            
        }
    }
}