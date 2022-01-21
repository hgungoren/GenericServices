using System;

namespace SK.SerendipGenericServise.KPersonelApi.Application.ResponseDto
{
    [Serializable]
    public class KPersonelIsyeriResponseDto
    {
        public long SubeObjId { get; set; }
        public string SubeAdi { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public long SubeBagliOlduguSubeObjId { get; set; }
    }
}