using Leaders.RedeemVoucher.App.ViewModels;

namespace Leaders.RedeemVoucher.App.Interfaces
{
    public interface IVoucherAppService
    {
        bool TryToRedeemVoucher(ref VoucherRedeemViewModel viewModel);
        bool LocateVoucher(ref VoucherRedeemViewModel viewModel);
        void GetVoucherDetails(ref AddEditVoucherViewModel viewModel);
        void GetVoucherList(AddEditVoucherViewModel viewModel);
    }
}