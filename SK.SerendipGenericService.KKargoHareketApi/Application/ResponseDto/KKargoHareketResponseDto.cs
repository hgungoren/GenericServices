using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KKargoHareketApi.Application.ResponseDto
{
    public class KKargoHareketResponseDto
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
    }
}