using Leaders.RedeemVoucher.Domain.Interfaces.Repositories;
using Leaders.RedeemVoucher.Domain.Interfaces.Services;

namespace Leaders.RedeemVoucher.Domain.Services
{
    public class VoucherHistoricDataService : IVoucherHistoricDataService
    {
        private readonly IVoucherHistoricDataRepository repository;
        public VoucherHistoricDataService(IVoucherHistoricDataRepository voucherHistoricDataRepository)
        {
            repository = voucherHistoricDataRepository; 
        }
    }
}