using System;

namespace SK.SerendipGenericServise.KPersonelApi.Application.ResponseDto
{
    [Serializable]
    public class KPersonelResponseDto
    { 
        public long ObjId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gorevi { get; set; }
        public bool? Aktif { get; set; }
        public long IsYeri_ObjId { get; set; }
        public string SicilNo { get; set; }
        public long Kullanici_ObjId { get; set; }

        /// <summary>
        /// Kullanıcı Mail Adresi 
        /// </summary>
        public string alan5 { get; set; }
    }
}