using Leaders.RedeemVoucher.App.Interfaces;
using Leaders.RedeemVoucher.App.ViewModels;
using Leaders.RedeemVoucher.Domain.Interfaces.Repositories;
using Leaders.RedeemVoucher.Domain.Interfaces.Services;

namespace Leaders.RedeemVoucher.App.Services
{
    public class VoucherAppService : IVoucherAppService
    {
        private readonly IVoucherService VoucherService;
        private readonly IVoucherRepository VoucherRepository;
        private readonly IVoucherHistoricDataService VoucherHistoricDataService;
        private readonly IVoucherHistoricDataRepository VoucherHistoricDataRepository;
        public VoucherAppService(IVoucherService voucherService,IVoucherRepository voucherRepository ,
            IVoucherHistoricDataRepository voucherHistoricDataRepository,IVoucherHistoricDataService voucherHistoricDataService)
        {
            VoucherService = voucherService;
            VoucherRepository = voucherRepository;
            VoucherHistoricDataService = voucherHistoricDataService;
            VoucherHistoricDataRepository = voucherHistoricDataRepository;
        }
        public bool TryToRedeemVoucher(ref VoucherRedeemViewModel viewModel)
        {
            var voucher = VoucherService.RedeemVoucher(viewModel.VoucherNo);
            if (voucher?.VoucherNo?.Length < 15) return false;
            
            return true;
        }

        public bool LocateVoucher(ref VoucherRedeemViewModel viewModel)
        {
            var voucher = VoucherRepository.GetByVoucherNo(viewModel.VoucherNo);
            if (voucher?.VoucherNo?.Length < 15) return false;

            viewModel.VoucherNo = voucher.VoucherNo;
            //TODO viewModel.RedeemAccount = !Missing especification!

            return true;
        }

        public void GetVoucherDetails(ref AddEditVoucherViewModel viewModel)
        {
            throw new System.NotImplementedException();
        }

        public void GetVoucherList(AddEditVoucherViewModel viewModel)
        {
            viewModel.VoucherEntries.Clear();
            foreach (var voucher in VoucherRepository.GetAll())
                viewModel.VoucherEntries.Add(voucher.VoucherNo);
        }
    }
}