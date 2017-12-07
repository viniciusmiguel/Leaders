using System;
using System.Collections.Generic;
using Leaders.RedeemVoucher.Domain.Entities;

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
        decimal OriginalAmount { get; }
        /// <summary>
        /// Current amount of vouchers
        /// </summary>
        decimal? CurrentAmount { get; }
        /// <summary>
        /// The last time the voucher was used
        /// </summary>
        DateTime? LastDateUsed { get; }
        IEnumerable<VoucherHistoricData> VoucherHistorics { get; }
    }
}