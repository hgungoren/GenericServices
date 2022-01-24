using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KKuryeLocationApi.Core.Entities
{
    public class KKuryeLocation
    {
        [Key]
        public long ObjId { get; set; }
        public long Kurye_ObjId { get; set; }
        public bool? Aktif { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
        public string MacAddress { get; set; }
        public long? Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public System.DateTime? Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public System.DateTime? Sistem_UpdateTime { get; set; }
        public byte? IsOther { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
        public byte[] Sistem_Timestamp { get; set; }
    }
}