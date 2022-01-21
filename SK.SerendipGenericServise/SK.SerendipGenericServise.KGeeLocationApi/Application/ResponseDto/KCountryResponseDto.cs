﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KGeeLocationApi.Application.ResponseDto
{
    public class KCountryResponseDto
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