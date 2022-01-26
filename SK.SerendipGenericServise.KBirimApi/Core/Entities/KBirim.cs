using System;
using System.ComponentModel.DataAnnotations;

namespace SK.SerendipGenericServise.KBirimApi.Core.Entities
{
    public class KBirim
    {
        [Key]
        public long ObjId { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
        public string Aciklama { get; set; }
        public string Adi { get; set; }
        public bool? Aktif { get; set; }
        public decimal? BirimFiyat { get; set; }
        public decimal? DesiBas { get; set; }
        public decimal? DesiBit { get; set; }
        public bool? KargoTakipVar { get; set; }
        public string Kodu { get; set; }
        public long? Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public DateTime? Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public DateTime? Sistem_UpdateTime { get; set; }
        public byte? IsOther { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
    }
}