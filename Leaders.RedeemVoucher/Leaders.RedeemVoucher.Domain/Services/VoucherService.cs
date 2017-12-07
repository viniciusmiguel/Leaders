using Leaders.RedeemVoucher.Domain.Entities;
using Leaders.RedeemVoucher.Domain.Interfaces.Repositories;
using Leaders.RedeemVoucher.Domain.Interfaces.Services;

namespace Leaders.RedeemVoucher.Domain.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly IVoucherRepository repository;
        public VoucherService(IVoucherRepository voucherRepository)
        {
            repository = voucherRepository;
        }

        public Voucher RedeemVoucher(string viewModelVoucherNo)
        {
            throw new System.NotImplementedException();
        }
    }
}