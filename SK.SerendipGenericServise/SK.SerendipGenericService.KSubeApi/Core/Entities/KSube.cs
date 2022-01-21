using SK.SerendipGenericServise.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace SK.SerendipGenericService.KSubeApi.Core.KSubeEntity
{
    public class KSube
    {
        [Key]
        public long ObjId { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
        public string Aciklama { get; set; }
        public string Adi { get; set; }
        public long? Adresi_ObjId { get; set; }
        public decimal? AktarmayaUzaklik { get; set; }
        public bool? Aktif { get; set; }
        public long? BagliOlduguAktarma_ObjId { get; set; }
        public long? BagliOlduguSube_ObjId { get; set; }
        public long? Carisi_ObjId { get; set; }
        public string Fax { get; set; }
        public decimal? GazeteBayiKDVOran { get; set; }
        public string Gsm { get; set; }
        public string GsmKisa { get; set; }
        public int? GunlukCalismaDurum { get; set; }
        public string IPTel { get; set; }
        public bool? IsAracSozlesmeKapali { get; set; }
        public bool? IsCariKapali { get; set; }
        public bool? IsFaturaKapali { get; set; }
        public System.DateTime? IslemTarihi { get; set; }
        public bool? IsMusteriSozlesmeKapali { get; set; }
        public bool? IsTahsilatKapali { get; set; }
        public bool? IsTesellumKapali { get; set; }
        public bool? IsTeslimatKapali { get; set; }
        public bool? IsYuklemeKapali { get; set; }
        public bool? IsKibris { get; set; }
        public string Kodu { get; set; }
        public string ReferansGrup { get; set; }
        public string SabitTel { get; set; }
        public long? Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public System.DateTime? Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public System.DateTime? Sistem_UpdateTime { get; set; }
        public long? SP_IsyeriObjId { get; set; }
        public KSubeTip? Tipi { get; set; }
        public KSubeTipTur? TipTur { get; set; }
        public bool? Faaliyettemi { get; set; }
        public int? OldGunlukCalismaDurum { get; set; }
        public System.DateTime? FaaliyetDurdurulmaTarihi { get; set; }
        public System.DateTime? KapatilmaTarihi { get; set; }
        public bool? IsSirketIciTesellumKapali { get; set; }
        public bool? IsMerkezSITesellumKapali { get; set; }
        public bool? IsBolgeSITesellumKapali { get; set; }
        public string NobetBitSaati { get; set; }
        public string EvrakKesimBitSaati { get; set; }
        public bool? IsSaatKontrolAcik { get; set; }
        public byte? IsOther { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
        public string Boylam { get; set; }
        public string Enlem { get; set; }
        public string GrupNo { get; set; }
        public string MikroKontrol { get; set; }
        public string EvrakKesimBasSaati { get; set; }
        public string EvrakKesimBasSaatiDefault { get; set; }
        public string EvrakKesimBitSaatiDefault { get; set; }
        public string EvrakKesimBasSaatiCts { get; set; }
        public string EvrakKesimBasSaatiCtsDefault { get; set; }
        public string EvrakKesimBitSaatiCts { get; set; }
        public string EvrakKesimBitSaatiCtsDefault { get; set; }
        public string EvrakKesimBasSaatiPzr { get; set; }
        public string EvrakKesimBasSaatiPzrDefault { get; set; }
        public string EvrakKesimBitSaatiPzr { get; set; }
        public string EvrakKesimBitSaatiPzrDefault { get; set; }
        public int? CikisKota { get; set; }
        public int? VarisKota { get; set; }
        public string BLink { get; set; }
        public string LinkUrl { get; set; }
    }
}