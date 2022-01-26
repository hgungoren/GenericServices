

using SK.SerendipGenericServise.KBirimApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericServise.KBirimApi.Controllers.v1
{
    public class KBirimController : BaseController
    {
        private IKBirimAppService _kBirimAppService;
        public KBirimController()
        {
            _kBirimAppService = new KBirimAppService();
        }

        public IHttpActionResult GetAll()
        {
            var result = _kBirimAppService.GetAll();
            return Json(result);
        }

        public IHttpActionResult GetByObjId(long id)
        {
            var result = _kBirimAppService.GetByObjId(id);
            return Json(result);
        }

        public IHttpActionResult GetByTrackingNo(string takipNo)
        {
            var result = _kBirimAppService.GetByTrackingNo(takipNo);
            return Json(result);
        }
    }
}