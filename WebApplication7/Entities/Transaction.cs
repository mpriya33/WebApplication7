using System;
using System.Collections.Generic;

namespace WebApplication7.Entities
{
    public partial class Transaction
    {
        public uint Rownum { get; set; }
        public string? Accno { get; set; }
        public string? Oldaccno { get; set; }
        public string? Ref { get; set; }
        public string? Ref1 { get; set; }
        public string? Ref2 { get; set; }
        public string Brcode { get; set; } = null!;
        public string? Trstat { get; set; }
        public string? Drcr { get; set; }
        public decimal? Amt { get; set; }
        public string? Userid { get; set; }
        public DateOnly Date { get; set; }
        public DateOnly? Backenddate { get; set; }
        public string? Time { get; set; }
        public string? Rvsl { get; set; }
        public string? Seqno { get; set; }
        public string? Oldseqno { get; set; }
        public string? Trcode { get; set; }
        public string? Send { get; set; }
        public string? SendSms { get; set; }
        public string? Response { get; set; }
        public string? ErrDes { get; set; }
        public uint? As400time { get; set; }
        public string? SendTime { get; set; }
        public string? ReceTime { get; set; }
        public string? Rem1 { get; set; }
        public string? Rem2 { get; set; }
        public uint Autonum { get; set; }
        public string? Ecuserid { get; set; }
        public string? Ecdate { get; set; }
        public string? CorrRef { get; set; }
        public string? Remark { get; set; }
        public uint Retry { get; set; }
        public string? Newseqno { get; set; }
        public string? Trrefn { get; set; }
    }
}
