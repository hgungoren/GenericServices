using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KCariApi.Core.Entities
{
    public class KCari
    {
        [Key]
        public long ObjId { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
        public long? Adresi_ObjId { get; set; }
        public bool? Aktif { get; set; }
        public string CepTel { get; set; }
        public int? Durumu { get; set; }
        public string EmailTeslimat { get; set; }
        public string EvTel { get; set; }
        public string FaturaAdresSatir1 { get; set; }
        public string FaturaAdresSatir2 { get; set; }
        public string FaturaUnvan { get; set; }
        public long? GazeteTahsilatci_ObjId { get; set; }
        public int? HesapBlokToleransGunSayisi { get; set; }
        public decimal? HesapKapamaBakiye { get; set; }
        public int? HesapKapamaDonemi { get; set; }
        public int? HesapKapamaGunu { get; set; }
        public decimal? HesapKapamaMinOdemeTutar { get; set; }
        public int? HesapTipi { get; set; }
        public bool? IsBlocked { get; set; }
        public string IsTel { get; set; }
        public bool? IsUstCari { get; set; }
        public string Kodu { get; set; }
        public string KrediKartiBanka { get; set; }
        public string KrediKartiCVV { get; set; }
        public string KrediKartiNo { get; set; }
        public string KrediKartiSahibi { get; set; }
        public string KrediKartiSKTar { get; set; }
        public string KrediKartiTip { get; set; }
        public int? OdemeGun { get; set; }
        public int? OdemeTip { get; set; }
        public int? Ozellik1 { get; set; }
        public int? Ozellik2 { get; set; }
        public long? Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public DateTime? Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public DateTime? Sistem_UpdateTime { get; set; }
        public long? SP_CariMuhasebeHesapSablonuObjId { get; set; }
        public long? SP_CariObjId { get; set; }
        public long? SP_MuhasebeKoduObjId { get; set; }
        public long? SP_OdemePlani { get; set; }
        public long? Sube_ObjId { get; set; }
        public int? Turu { get; set; }
        public decimal? UAAliciCariHesapKapamaLimiti { get; set; }
        public decimal? UAEvrakLimiti { get; set; }
        public decimal? UAGonderenCariLimiti { get; set; }

        public decimal? UAGonderiKarsiBakiyeToplami { get; set; }
        public string Unvan { get; set; }
        public long? UstCari_ObjId { get; set; }
        public string VergiDaire { get; set; }
        public string VergiNo { get; set; }
        public string YetkiliKisi { get; set; }
        public string WebUserName { get; set; }
        public string WebPassword { get; set; }
        public long? DagitimSubesi_ObjId { get; set; }
        public bool? IsPazarlamacisiVar { get; set; }
        public long? Sektor_ObjId { get; set; }
        public bool? IsWebSatisiVar { get; set; }
        public bool? IsGitGel { get; set; }
        public long? Rapor_UstCari_ObjId { get; set; }
        public byte? IsOther { get; set; }
        public bool? IsKapidanTahsilat { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
        public string MusteriNo { get; set; }
        public string BayiNo { get; set; }
        public bool IsCariSozlesmeRaporu { get; set; }
        public string GGPassword { get; set; }
        public long? VergiDairesi_ObjId { get; set; }
        public string ComputedUnvan { get; set; }
        public int? PazarlamaciDurumu { get; set; }
        public bool? isTCCitizen { get; set; }
        public bool? IsIadeOnayVerilsin { get; set; }
        public string PostaKodu { get; set; }
        public bool IsCariKilitli { get; set; }
        public byte[] Resim { get; set; }
        public long? SegmentKodu_ObjId { get; set; }
        public long? Zimmetli_ObjId { get; set; }
        public string EvrakKaydetmekIcinYetkiliSubeler { get; set; }
        public string WebServisSifre { get; set; }
        public bool? EKargoSmsleGirisOlsun { get; set; }
        public bool EKargoSmsleGirisOlsunYeni { get; set; }
        public bool? IlceKontroluOlmasin { get; set; }
        public long? TeslimEdenYetkili_ObjId { get; set; }
        public long? TeslimAlanYetkili_ObjId { get; set; }
        public string Uyruk { get; set; }
        public bool? IsPazaryeriMusterisi { get; set; }
        public string SiparisEkraniKullanilsin { get; set; }
        public string SmsUnvani { get; set; }
    }
}