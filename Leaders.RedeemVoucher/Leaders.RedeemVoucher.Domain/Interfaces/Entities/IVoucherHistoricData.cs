using System;
using Leaders.RedeemVoucher.Domain.Entities;

namespace Leaders.RedeemVoucher.Domain.Interfaces.Entities
{
    /// <summary>
    /// Transaction Historic data for Voucher
    /// </summary>
    public interface IVoucherHistoricData : IEntity
    {
        /// <summary>
        /// Voucher Number Associated with this record
        /// </summary>
        string VoucherNo { get; }
        /// <summary>
        /// Date of use
        /// </summary>
        DateTime Date { get; }
        /// <summary>
        /// Docket Number
        /// </summary>
        string DocketNo { get; }
        /// <summary>
        /// Amount of voucher used
        /// </summary>
        double Amount { get; }
        /// <summary>
        /// Point of Sale Number
        /// </summary>
        int POSNo { get; }
        /// <summary>
        /// Reference
        /// </summary>
        string Reference { get; }
        Voucher Voucher { get; }
    }
}