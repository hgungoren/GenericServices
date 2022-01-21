using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KKargoHareketApi.Application.Dto
{
    public class KKargoHareketDto
    {
        public long ObjId { get; set; }
        public string Aciklama { get; set; }
        public bool? Aktif { get; set; }
        public long? Arac_ObjId { get; set; }
        public long? AracSefer_ObjId { get; set; }
        public long? AracSeferAyak_ObjId { get; set; }
        public DateTime? HareketTar { get; set; }
        public int HareketTip { get; set; }
        public long? Kargo_ObjId { get; set; }
        public long? KargoTeslimat_ObjId { get; set; }
        public long? Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public DateTime? Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public DateTime? Sistem_UpdateTime { get; set; }
        public long? Sube_ObjId { get; set; }
        public int? HareketKaynak { get; set; }
        public long? IslemNo { get; set; }
        public int? RotaNo { get; set; }
        public long? Kurye_ObjId { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
        public byte? IsOther { get; set; }
        public bool? IsTahsilatSubeDegisti { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
    }
}