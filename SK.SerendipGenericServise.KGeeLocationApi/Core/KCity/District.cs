using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KGeeLocationApi.Core.KCity
{
    public class District
    {
        public long ObjId { get; set; }
        public string Sistem_Timestamp { get; set; }
        public string Aciklama { get; set; }
        public string Adi { get; set; }
        public bool Aktif { get; set; }
        public long Ili_ObjId { get; set; }
        public string Kodu { get; set; }
        public long Sirketi_ObjId { get; set; }
        public string Sistem_InsertLogin { get; set; }
        public DateTime Sistem_InsertTime { get; set; }
        public string Sistem_TransactionId { get; set; }
        public string Sistem_UpdateLogin { get; set; }
        public string Sistem_UpdateTime { get; set; }
        public int IsOther { get; set; }
        public string Sistem_InsertTerminal { get; set; }
        public string Sistem_UpdateTerminal { get; set; }
    }



}