using SK.SerendipGenericService.KKullaniciApi.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SK.SerendipGenericService.KKullaniciApi.Controllers.v1
{
    public class KKullaniciController : BaseController
    {
        private IKKullaniciAppService _kKullaniciAppService;
        public KKullaniciController()
        {
            _kKullaniciAppService = new KKullaniciAppService();
        }
        // GET: KKullanici
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetMail/{id}")]
        public IHttpActionResult GetMail(long id)
        {
            var data = _kKullaniciAppService.GetMail(id);
            return Json(data);
        }
    }
}