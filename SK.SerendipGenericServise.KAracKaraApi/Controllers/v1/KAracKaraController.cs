using SK.SerendipGenericServise.KAracKaraApi.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SK.SerendipGenericServise.KAracKaraApi.Controllers.v1
{
    public class KAracKaraController : BaseController
    {
        private IKAracKaraAppService _kAracKaraAppService;
        public KAracKaraController()
        {
            _kAracKaraAppService = new KAracKaraAppService();
        }


        public IHttpActionResult GetGorevler(long id)
        {
            var result = _kAracKaraAppService.GetAsync(id);
            return Json(result, new Newtonsoft.Json.JsonSerializerSettings { });
        }
    }
}