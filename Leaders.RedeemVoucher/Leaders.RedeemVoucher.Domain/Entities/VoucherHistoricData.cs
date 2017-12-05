using System;
using Leaders.RedeemVoucher.Domain.Interfaces.Entities;

namespace Leaders.RedeemVoucher.Domain.Entities
{
    public class VoucherHistoricData : Entity, IVoucherHistoricData
    {
        public VoucherHistoricData() { }

        public string VoucherNo { get; protected set; }

        public DateTime Date { get; protected set; }

        public string DocketNo { get; protected set; }

        public double Amount { get; protected set; }

        public int POSNo { get; protected set; }

        public string Reference { get; protected set; }
    }
}