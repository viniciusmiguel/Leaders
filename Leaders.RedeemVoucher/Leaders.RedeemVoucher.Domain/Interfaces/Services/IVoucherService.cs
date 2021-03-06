﻿using Leaders.RedeemVoucher.Domain.Entities;

namespace Leaders.RedeemVoucher.Domain.Interfaces.Services
{
    public interface IVoucherService
    {
        Voucher RedeemVoucher(string viewModelVoucherNo);
        string UpdateVoucher(Voucher voucher);
        string CreateVoucher(Voucher voucher);
    }
}