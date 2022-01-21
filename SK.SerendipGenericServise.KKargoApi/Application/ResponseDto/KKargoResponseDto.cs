
using Newtonsoft.Json;
using System;

namespace SK.SerendipGenericServise.KKargoApi.Application.ResponseDto
{

    [Serializable]
    public class KKargoResponseDto 
    {

        [JsonProperty("yil")]
        public int Yil { get; set; }
        [JsonProperty("ay")]
        public int Ay { get; set; }
        [JsonProperty("subeObjId")]
        public long SubeObjId { get; set; }
        [JsonProperty("evrakAdedi")]
        public int EvrakAdedi { get; set; }
        [JsonProperty("tip")]
        public int Tip { get; set; }


    }
}