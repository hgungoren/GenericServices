using SK.SerendipGenericService.KKuryeLocationApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericService.KKuryeLocationApi.Controllers.v1
{
    public class KKuryeLocationController : BaseController
    {
        private IKKuryeLocationAppService _kKuryeLocationAppService;
        public KKuryeLocationController()
        {
            _kKuryeLocationAppService = new KKuryeLocationAppService();
        }
        public IHttpActionResult GetKKuryeLocationByKuryeObjId (long id)
        {
            var result = _kKuryeLocationAppService.GetKKuryeLocationByKuryeObjId(id);

            return Json(result);
        }

        public IHttpActionResult GetKKuryeLocationByTrackingNo(string trackingNo)
        {
            var result = _kKuryeLocationAppService.GetKKuryeLocationByTrackingNo(trackingNo);

            return Json(result);
        }
    }
}