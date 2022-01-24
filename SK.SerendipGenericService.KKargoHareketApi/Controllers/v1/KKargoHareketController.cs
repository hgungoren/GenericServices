using SK.SerendipGenericService.KKargoHareketApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericService.KKargoHareketApi.Controllers.v1
{
    public class KKargoHareketController : BaseController
    {
        private IKKargoHareketAppService _kKargoHareketAppService;
        public KKargoHareketController()
        {
            _kKargoHareketAppService = new KKargoHareketAppService();
        }

        public IHttpActionResult Get(long id)
        {
            var result = _kKargoHareketAppService.Get(id);
            return Json(result);

        }

        public IHttpActionResult GetAracObjId(long id)
        {
            var result = _kKargoHareketAppService.GetAracObjId(id);
            return Json(result);

        }

        public IHttpActionResult GetKuryeObjId(long id)
        {
            var result = _kKargoHareketAppService.GetKuryeObjId(id);
            return Json(result); 
        }
    }
}