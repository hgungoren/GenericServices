﻿using System;
using System.ComponentModel.DataAnnotations;


namespace SK.SerendipGenericServise.KAracKaraApi.Core.KAracKara
{
    public class KAracKara 
    {
        [Key]
        public long ObjId { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
        public bool? Aktif { get; set; }
        public int? AracBelge { get; set; }
        public string AracTakipKitNo { get; set; }
        public decimal? BakimPeriyotGun { get; set; }
        public decimal? BakimPeriyotKm { get; set; }
        public int? Cinsi { get; set; }
        public string EskiSahip { get; set; }
        public long? Hat_ObjId { get; set; }
        public decimal? KapasiteDesi { get; set; }
        public decimal? KapasiteKG { get; set; }
        public decimal? KasaBoy { get; set; }
        public decimal? KasaEn { get; set; }
        public int? KasaRenk { get; set; }
        public int? KasaTip { get; set; }
        public decimal? KasaYukseklik { get; set; }
        public int? KupaRenk { get; set; }
        public int? Marka { get; set; }
        public int? Model { get; set; }
        public string Plaka { get; set; }
        public string RuhsatAdres { get; set; }
        public string RuhsatNo { get; set; }
        public string RuhsatSahibi { get; set; }
        public string RuhsatSahipTel { get; set; }
        public string SasiNo { get; set; }
        public long? Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public DateTime? Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public DateTime? Sistem_UpdateTime { get; set; }
        public long? SonAracBakim_ObjId { get; set; }
        public decimal? SonKm { get; set; }
        public long? Sube_ObjId { get; set; }
        public DateTime? TrafikCikisTar { get; set; }
        public string VergiDaire { get; set; }
        public string VergiNo { get; set; }
        public string YakitTakipKitNo { get; set; }
        public int? YakitTip { get; set; }
        public decimal? YakitTuketim100km { get; set; }
        public string Aciklama { get; set; }
        public string Adi { get; set; }
        public long? Aktarma_ObjId { get; set; }
        public int? AracStatu { get; set; }
        public long? Birim_ObjId { get; set; }
        public long? Bolge_ObjId { get; set; }
        public long? Carisi_ObjId { get; set; }
        public DateTime? IseBaslayabilTar { get; set; }
        public bool? IsOnOnayli { get; set; }
        public decimal? kapasiteMetrekup { get; set; }
        public decimal? KaskoBedeli { get; set; }
        public DateTime? KaskoSigortaBitisTar { get; set; }
        public string KaskoSigortaSirket { get; set; }
        public string Kodu { get; set; }
        public int? KullanimSekli { get; set; }
        public decimal? MotorGucu { get; set; }
        public decimal? MTVYilAy1 { get; set; }
        public decimal? MTVYilAy2 { get; set; }
        public decimal? MuayeneBedeli { get; set; }
        public DateTime? MuayeneBitisTar { get; set; }
        public int? OtomatikGecisTip { get; set; }
        public decimal? PoasKmSonBeyan { get; set; }
        public DateTime? PoasKmSonBeyanTar { get; set; }
        public decimal? SilindirHacmi { get; set; }
        public decimal? SirketKmSonBeyan { get; set; }
        public DateTime? SirketKmSonBeyanTar { get; set; }
        public long? Sozlesme_ObjId { get; set; }
        public int? SozlesmeDurum { get; set; }
        public DateTime? SozlesmeGecerliTar { get; set; }
        public int? SozlesmeTur { get; set; }
        public long? Surucu_ObjId { get; set; }
        public string SurucuAd { get; set; }
        public long? SurucuAdres_ObjId { get; set; }
        public string SurucuBelgeNumarasi { get; set; }
        public string SurucuCepTel { get; set; }
        public string SurucuEhliyetAldigiYer { get; set; }
        public string SurucuEhliyetNo { get; set; }
        public string SurucuEhliyetSinif { get; set; }
        public string SurucuEvTel { get; set; }
        public string SurucuPersonelSicilNo { get; set; }
        public string SurucuUnvani { get; set; }
        public decimal? TalepUcret { get; set; }
        public int? TasitKarti { get; set; }
        public decimal? TrafikSigortaBedeli { get; set; }
        public DateTime? TrafikSigortaBitisTar { get; set; }
        public string TrafikSigortaSirket { get; set; }
        public int? VergiLevha { get; set; }
        public int? VergiMukellef { get; set; }
        public decimal? VerilenUcret { get; set; }
        public decimal? YilAyBazindaOzelKullanim { get; set; }
        public bool? IsUzunDonemKiralik { get; set; }
        public string Barkod { get; set; }
        public int? AracDurum { get; set; }
        public long? SonHareket_ObjId { get; set; }
        public string SurucuAd1 { get; set; }
        public string SurucuBelgeNumarasi1 { get; set; }
        public string SurucuCepTel1 { get; set; }
        public string SurucuEhliyetAldigiYer1 { get; set; }
        public string SurucuEhliyetNo1 { get; set; }
        public string SurucuEhliyetSinif1 { get; set; }
        public string SurucuEvTel1 { get; set; }
        public string SurucuPersonelSicilNo1 { get; set; }
        public string SurucuUnvani1 { get; set; }
        public long? Surucu1_ObjId { get; set; }
        public byte? IsOther { get; set; }
        public DateTime? Surucu1BasTarihi { get; set; }
        public DateTime? Surucu1BitTarihi { get; set; }
        public DateTime? Surucu2BasTarihi { get; set; }
        public DateTime? Surucu2BitTarihi { get; set; }
        public long? AracMarka_ObjId { get; set; }
        public string UyducihaziId { get; set; }
        public string UyduTelefonNumarasi { get; set; }
        public DateTime? UyduTakilmaTarihi { get; set; }
        public DateTime? UyduSokulmeTarihi { get; set; }
        public string UyduCihazTipi { get; set; }
        public DateTime? LocaMontajTarihi { get; set; }
        public bool? LocaVar { get; set; }
        public DateTime? FileMontajTarihi { get; set; }
        public bool? FileVar { get; set; }
        public long? TelefonMarkasi_ObjId { get; set; }
        public long? TelefonModeli_ObjId { get; set; }
        public string IMeiNumarasi { get; set; }
        public string SimKartNosu { get; set; }
        public decimal? MuayeneKm { get; set; }
        public DateTime? BakimTarihi { get; set; }
        public string BakimEvrakNo { get; set; }
        public decimal? BakimTutar { get; set; }
        public string BakimAciklama { get; set; }
        public bool? IsRuhsatFotokopisi { get; set; }
        public bool? IsTrafikSigortaPolicesi { get; set; }
        public bool? IsKaskoPolicesi { get; set; }
        public bool? IsK1YetkiBelgesi { get; set; }
        public bool? IsTasimaSozlesmesi { get; set; }
        public bool? IsAracSahibiKimlikFotokopisi { get; set; }
        public bool? IsAracSahibiIkametgahBelgesi { get; set; }
        public bool? IsAracSahibiSabikaKaydi { get; set; }
        public bool? IsAracSahibiVergiLevhasi { get; set; }
        public bool? IsAracSahibiTeminatSenedi { get; set; }
        public bool? IsAracSurucusuEhliyetFotokopisi { get; set; }
        public bool? IsAracSurucusuKimlikFotokopisi { get; set; }
        public bool? IsAracSurucusuIkametgahBelgesi { get; set; }
        public bool? IsAracSurucusuSabikaKaydiBelgesi { get; set; }
        public bool? IsAracSurucusuTeminatSenedi { get; set; }
        public bool? IsAracSurucusuSrcBelgesi { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
        public long? CariHesabi_ObjId { get; set; }
        public long? AracMarkaModel_ObjId { get; set; }
        public string MotorNo { get; set; }
        public decimal? NetAgirlik { get; set; }
        public decimal? AzamiYukluAgirlik { get; set; }
        public string TescilNo { get; set; }
        public string IlkTescilNo { get; set; }
        public string ModelAciklama { get; set; }
    }
}