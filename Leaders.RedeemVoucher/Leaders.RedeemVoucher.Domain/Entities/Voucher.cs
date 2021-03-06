﻿using System;
using System.Collections.Generic;
using Leaders.RedeemVoucher.Domain.Interfaces.Entities;

namespace Leaders.RedeemVoucher.Domain.Entities
{
    /// <summary>
    /// Implementation for IVoucher
    /// </summary>
    public class Voucher : Entity, IVoucher
    {
        public Voucher() { } // EF Constructor
        public Voucher(string voucherNo, DateTime dateSold,
            decimal originalAmount, decimal currentAmount, DateTime lastDateUsed)
        {
            VoucherNo = voucherNo;
            DateSold = dateSold;
            OriginalAmount = originalAmount;
            CurrentAmount = currentAmount;
            LastDateUsed = lastDateUsed;
        }
        public Voucher(int autoId, string voucherNo, DateTime dateSold, 
            decimal originalAmount, decimal currentAmount, DateTime lastDateUsed) : base(autoId)
        {
            VoucherNo = voucherNo;
            DateSold = dateSold;
            OriginalAmount = originalAmount;
            CurrentAmount = currentAmount;
            LastDateUsed = lastDateUsed;
        }
        /// <summary>
        /// The voucher number
        /// </summary>
        public string VoucherNo { get; protected set; }
        /// <summary>
        /// The date that the voucher was sold
        /// </summary>
        public DateTime DateSold { get; protected set; }
        /// <summary>
        /// The original amount of vouchers
        /// </summary>
        public decimal OriginalAmount { get; protected set; }
        /// <summary>
        /// The current amount of vouchers
        /// </summary>
        public decimal? CurrentAmount { get; protected set; }
        /// <summary>
        /// the last day that the voucher was used
        /// </summary>
        public DateTime? LastDateUsed { get; protected set; }
        // Object for EF PK -> FK
        public IEnumerable<VoucherHistoricData> VoucherHistorics { get; protected set; }

        public override string ToString()
        {
            return "Voucher:" + VoucherNo;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            try
            {
                if (((Voucher) obj).VoucherNo.Equals(VoucherNo))
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return AutoID.GetHashCode() * VoucherNo.GetHashCode();
        }
    }
}