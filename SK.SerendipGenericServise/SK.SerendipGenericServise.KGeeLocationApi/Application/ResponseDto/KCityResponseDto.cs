using Newtonsoft.Json;
using System;


namespace SK.SerendipGenericServise.KGeeLocationApi.Application.ResponseDto
{

    [Serializable]
    public class KCityResponseDto
    {

        [JsonProperty("objId")]
        public long ObjId { get; set; }

        [JsonProperty("aciklama")] 
        public string Aciklama { get; set; }

        [JsonProperty("adi")]
        public string Adi { get; set; }

        [JsonProperty("aktif")] 
        public bool Aktif { get; set; }

    }
}