﻿using SK.SerendipGenericServise.Core.Enums;
using Serendip.Entity;

namespace SK.SerendipGenericService.KSubeApi.Application.ResponseDto
{
    public class KSubeReponseDto: Entity
    {
        public string ObjId { get; set; }
        public string Adi { get; set; }
        public int PersonelSayisi { get; set; }
        public int ToplamSayi { get; set; }
        public bool? Aktif { get; set; }
        public KSubeTip? Tipi { get; set; }
        public KSubeTipTur? TipTur { get; set; }
        public string BagliOlduguSube_ObjId { get; set; }
        public string SabitTel { get; set; }
    }
}