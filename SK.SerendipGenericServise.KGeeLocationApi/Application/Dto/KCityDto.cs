

using System;

namespace SK.SerendipGenericServise.KGeeLocationApi.Application.Dto
{

    [Serializable]
    public class KCityDto 
    {
        public long ObjId { get; set; }
        public string Aciklama { get; set; }
        public string Adi { get; set; }
        public bool Aktif { get; set; }

    }
}