using System.Collections.Generic;

namespace Leaders.RedeemVoucher.App.ViewModels
{
    public class AddEditVoucherViewModel
    {
        public AddEditVoucherViewModel()
        {
            VoucherEntries = new List<string>();
        }
        public List<string> VoucherEntries { get; }
        public string VoucherEntry { get; set; }
    }
}