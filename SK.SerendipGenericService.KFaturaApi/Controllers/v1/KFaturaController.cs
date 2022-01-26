using SK.SerendipGenericService.KFaturaApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericService.KFaturaApi.Controllers.v1
{
    public class KFaturaController : BaseController
    {
        private IKFaturaAppService _kFaturaAppService;
        public KFaturaController()
        {
            _kFaturaAppService = new KFaturaAppService();
        }

        public IHttpActionResult GetByTrackingNo(string takipNo)
        {
            var result = _kFaturaAppService.GetByTrackingNo(takipNo);
            return Json(result);
        }
    }
}