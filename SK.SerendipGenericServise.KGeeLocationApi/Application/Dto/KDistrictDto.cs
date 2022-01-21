using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KGeeLocationApi.Application.Dto
{
    public class KDistrictDto
    {
        public long ObjId { get; set; }
        public string Aciklama { get; set; }
        public string Adi { get; set; }
        public bool Aktif { get; set; }
        public long Ili_ObjId { get; set; }

    }
}