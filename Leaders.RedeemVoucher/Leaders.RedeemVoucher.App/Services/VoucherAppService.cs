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
        public string TryToRedeemVoucher(ref VoucherRedeemViewModel viewModel)
        {
            var voucher = VoucherService.RedeemVoucher(viewModel.VoucherNo);
            if (voucher?.VoucherNo?.Length < 15) return "Voucher Not Valid";
            
            return null;
        }

        public string LocateVoucher(ref VoucherRedeemViewModel viewModel)
        {
            var voucher = VoucherRepository.GetByVoucherNo(viewModel.VoucherNo);
            if (voucher?.VoucherNo?.Length < 15) return "Voucher Not Exists";

            viewModel.VoucherNo = voucher.VoucherNo;
            //TODO viewModel.RedeemAccount = !Missing especification!

            return null;
        }

        public void GetVoucherDetails(ref AddEditVoucherViewModel viewModel)
        {
            
        }

        public void GetVoucherList(AddEditVoucherViewModel viewModel)
        {
            viewModel.VoucherEntries.Clear();
            foreach (var voucher in VoucherRepository.GetAll())
                viewModel.VoucherEntries.Add(voucher.VoucherNo);
        }

        public string UpdateVoucher(ref AddEditVoucherViewModel viewModel)
        {

            return null;
        }

        public string CreateVoucher(ref AddEditVoucherViewModel viewModel)
        {

            return null;
        }
    }
}