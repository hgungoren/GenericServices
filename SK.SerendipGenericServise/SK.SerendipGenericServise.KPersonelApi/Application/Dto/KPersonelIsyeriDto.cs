using System;

namespace SK.SerendipGenericServise.KPersonelApi.Application.Dto
{
    [Serializable]
    public class KPersonelIsyeriDto : Serendip.Entity.Entity
    {
        public long SubeObjId { get; set; }
        public string SubeAdi { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public long SubeBagliOlduguSubeObjId { get; set; }
    }
}