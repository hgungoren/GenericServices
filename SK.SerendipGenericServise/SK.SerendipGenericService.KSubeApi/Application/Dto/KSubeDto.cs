﻿using SK.SerendipGenericServise.Core.Enums; 

namespace SK.SerendipGenericService.KSubeApi.Application.Dto
{
    public class KSubeDto : Serendip.Entity.Entity
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