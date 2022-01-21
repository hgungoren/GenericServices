using System.ComponentModel.DataAnnotations;

namespace SK.SerendipGenericServise.KPersonelApi.Core.KPersonels
{
    public class KPersonel
    {
        [Key]
        public long ObjId { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
        public string Ad { get; set; }
        public bool? Aktif { get; set; }
        public string AskerlikDurumu { get; set; }
        public string CepTelefonu { get; set; }
        public string CocukSayisi { get; set; }
        public string Departmani { get; set; }
        public string EvTelefonu { get; set; }
        public string Gorevi { get; set; }
        public System.DateTime? GrubaGirisTarihi { get; set; }
        public string Grubu { get; set; }
        public long? IsYeri_ObjId { get; set; }
        public string MedeniDurum { get; set; }
        public string OgrenimDurumu { get; set; }
        public System.DateTime? PersonelinKidemi { get; set; }
        public string SicilNo { get; set; }
        public long? Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public System.DateTime? Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public System.DateTime? Sistem_UpdateTime { get; set; }
        public string Soyad { get; set; }
        public string Barkod { get; set; }
        public System.DateTime? SonHareketTarihi { get; set; }
        public int? SonHareketTip { get; set; }
        public long? SonSube_ObjId { get; set; }
        public long? TCKimlikNo { get; set; }
        public long? Vardiya_ObjId { get; set; }
        public string HakEttigiGunSayisi { get; set; }
        public System.DateTime? IzinHakEdisTarihi { get; set; }
        public string KalanGunSayisi { get; set; }
        public string KullanilanGunSayisi { get; set; }
        public string tempRakam1 { get; set; }
        public string tempRakam2 { get; set; }
        public System.DateTime? tempTarih { get; set; }
        public string tempYazi { get; set; }
        public string KuryeSifre { get; set; }
        public string AdiSoyadi { get; set; }
        public int? GorevDurum { get; set; }
        public long? SP_KullaniciObjId { get; set; }
        public long? Kullanici_ObjId { get; set; }
        public byte? IsOther { get; set; }
        public string Adres { get; set; }
        public System.DateTime? DogumTarihi { get; set; }
        public System.DateTime? EvlilikTarihi { get; set; }
        public System.DateTime? SskTarihi { get; set; }
        public string alan1 { get; set; }
        public string alan2 { get; set; }
        public string alan3 { get; set; }
        public string alan4 { get; set; }
        public string alan5 { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string MacAddress { get; set; }
        public System.DateTime? SonIslemZamani { get; set; }
        public long? PersonelTicari_ObjId { get; set; }
    }
}
