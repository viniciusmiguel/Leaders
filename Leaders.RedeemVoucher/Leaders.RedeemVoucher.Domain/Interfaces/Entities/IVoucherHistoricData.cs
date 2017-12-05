using System;

namespace Leaders.RedeemVoucher.Domain.Interfaces.Entities
{
    /// <summary>
    /// Transaction Historic data for Voucher
    /// </summary>
    public interface IVoucherHistoricData : IEntity
    {
        string VoucherNo { get; }
        DateTime Date { get; }
        string DocketNo { get; }
        double Amount { get; }
        int POSNo { get; }
        string Reference { get; }
    }
}