using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KKullaniciApi.Application.Dto
{
    public class KKullaniciDto : Serendip.Entity.Entity
    {
        public long ObjId { get; set; }
        public string Email { get; set; }
    }
}