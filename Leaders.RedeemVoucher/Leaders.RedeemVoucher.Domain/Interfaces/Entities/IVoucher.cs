using System;

namespace Leaders.RedeemVoucher.Domain.Interfaces.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a Voucher Entity
    /// </summary>
    public interface IVoucher : IEntity
    {
        /// <summary>
        /// Voucher Number
        /// </summary>
        string VoucherNo { get; }
        /// <summary>
        /// Date that the voucher was sold
        /// </summary>
        DateTime DateSold { get; }
        /// <summary>
        /// Original amount of vouchers
        /// </summary>
        double OriginalAmount { get; }
        /// <summary>
        /// Current amount of vouchers
        /// </summary>
        double CurrentAmount { get; }
        /// <summary>
        /// The last time the voucher was used
        /// </summary>
        DateTime LastDateUsed { get; }
    }
}