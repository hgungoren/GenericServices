using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KKargoApi.Core.KKargos
{
    public class KKargo
    {
        public int Yil { get; set; }
        public int Ay { get; set; }
        public long SubeObjId { get; set; }
        public int EvrakAdedi { get; set; }
        public int Tip { get; set; }

    }
}