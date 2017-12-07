using System;
using Leaders.RedeemVoucher.Domain.Interfaces.Entities;

namespace Leaders.RedeemVoucher.Domain.Entities
{
    /// <summary>
    /// Implementationfor IVoucherHistoricData
    /// </summary>
    public class VoucherHistoricData : Entity, IVoucherHistoricData
    {
        public VoucherHistoricData() { }
        public VoucherHistoricData(int id, string voucherNo, DateTime date, string docketNo,
            decimal amount, int posNo, string reference) : base(id)
        {
            VoucherNo = voucherNo;
            Date = date;
            DocketNo = docketNo;
            Amount = amount;
            POSNo = posNo;
            Reference = reference;
        }
        public VoucherHistoricData(string voucherNo, DateTime date, string docketNo, 
            decimal amount, int posNo, string reference)
        {
            VoucherNo = voucherNo;
            Date = date;
            DocketNo = docketNo;
            Amount = amount;
            POSNo = posNo;
            Reference = reference;
        }

        public string VoucherNo { get; protected set; }

        public DateTime Date { get; protected set; }

        public string DocketNo { get; protected set; }

        public decimal Amount { get; protected set; }

        public int POSNo { get; protected set; }

        public string Reference { get; protected set; }
        //Object for EF FK.
        public Voucher Voucher { get; protected set; }
    }
}