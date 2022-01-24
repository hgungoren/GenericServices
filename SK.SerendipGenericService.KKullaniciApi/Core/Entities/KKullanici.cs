using System;
using System.ComponentModel.DataAnnotations;

namespace SK.SerendipGenericService.KKullaniciApi.Core.Entities
{
    public class KKullanici
    {
        [Key]
        public long ObjId { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<long> AktifDepo_ObjId { get; set; }
        public Nullable<long> AktifIsYeri_ObjId { get; set; }
        public Nullable<long> AktifSirketi_ObjId { get; set; }
        public string Login { get; set; }
        public string Sifre { get; set; }
        public Nullable<long> Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public Nullable<System.DateTime> Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public Nullable<System.DateTime> Sistem_UpdateTime { get; set; }
        public string TamAdi { get; set; }
        public Nullable<long> SatanPersonel_ObjId { get; set; }
        public Nullable<System.DateTime> SonGirisZamani { get; set; }
        public string Email { get; set; }
        public Nullable<long> AlanPersonel_ObjId { get; set; }
        public Nullable<bool> OzelDepoFiltresiUygulanir { get; set; }
        public Nullable<long> TicariIslemGrubu_ObjId { get; set; }
        public Nullable<long> GenelGrup_ObjId { get; set; }
        public Nullable<bool> B2CSozlesmesiOnaylandi { get; set; }
        public Nullable<long> RefCariHesabi_ObjId { get; set; }
        public byte IsOther { get; set; }
        public Nullable<long> EkGrup1_ObjId { get; set; }
        public Nullable<long> EkGrup2_ObjId { get; set; }
        public string PersonelNo { get; set; }
        public Nullable<bool> Kontrol { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
        public string MusteriTemsilcisiEmail { get; set; }
        public Nullable<byte> KullaniciTipi { get; set; }
        public Nullable<long> SatisOzelGrup_ObjId { get; set; }
        public string TamAdiWithLogin { get; set; }
        public string CepTelefonu { get; set; }
    }
}