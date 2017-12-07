namespace Leaders.RedeemVoucher.App.ViewModels
{
    public class VoucherRedeemViewModel
    {
        public VoucherRedeemViewModel()
        {
            ButtonRedeem = false;
        }
        public string VoucherNo { get; set; }
        public string RedeemAccount { get; set; }
        public string Remarks { get; set; }
        public bool ButtonRedeem { get; set; }
    }
}