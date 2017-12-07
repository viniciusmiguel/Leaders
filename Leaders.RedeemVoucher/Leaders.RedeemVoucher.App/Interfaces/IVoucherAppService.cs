using Leaders.RedeemVoucher.App.ViewModels;

namespace Leaders.RedeemVoucher.App.Interfaces
{
    public interface IVoucherAppService
    {
        string TryToRedeemVoucher(ref VoucherRedeemViewModel viewModel);
        string LocateVoucher(ref VoucherRedeemViewModel viewModel);
        void GetVoucherDetails(ref AddEditVoucherViewModel viewModel);
        void GetVoucherList(AddEditVoucherViewModel viewModel);
        string UpdateVoucher(ref AddEditVoucherViewModel viewModel);
        string CreateVoucher(ref AddEditVoucherViewModel viewModel);
    }
}