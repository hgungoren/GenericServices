using SK.SerendipGenericServise.InkaGorevlerApi.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SK.SerendipGenericServise.InkaGorevlerApi.Controllers.v1
{
    public class KInkaGorevlerController : BaseController
    {

        private IKInkaGorevlerAppService _kInkaGorevlerAppService;
        public KInkaGorevlerController()
        {
            _kInkaGorevlerAppService = new KInkaGorevlerAppService();
        }

        public IHttpActionResult GetGorevler()
        {
            var result = _kInkaGorevlerAppService.GetGorevler();
            return Json(result, new Newtonsoft.Json.JsonSerializerSettings { });
        }


        public IHttpActionResult GetGorevler(string key)
        {
            var result = _kInkaGorevlerAppService.GetGorevler(key);
            return Json(result, new Newtonsoft.Json.JsonSerializerSettings { });
        }
    }
}