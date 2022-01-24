using SK.SerendipGenericService.KKullaniciApi.Application;
using System.Web.Http;

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
        [HttpGet]
        [Route("GetMail/{id}")]
        public IHttpActionResult GetMail(long id)
        {
            var data = _kKullaniciAppService.GetMail(id);
            return Json(data);
        }
    }
}