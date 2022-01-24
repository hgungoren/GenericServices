using SK.SerendipGenericServise.KCariApi.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SK.SerendipGenericServise.KCariApi.Controllers.v1
{
    public class KCariController : BaseController
    {
        private IKCariAppService _kCariAppService;
        public KCariController()
        {
            _kCariAppService = new KCariAppService();
        }

        public IHttpActionResult Get(long id)
        {
            var result = _kCariAppService.GetByObjId(id);
            return Json(result);
        }
    }
}