using SK.SerendipGenericService.KTesellumApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericService.KTesellumApi.Controllers.v1
{
    public class KTesellumController : BaseController
    {
        private IKTesellumAppService _kTesellumAppService;
        public KTesellumController()
        {
            _kTesellumAppService = new KTesellumAppService();
        }

        public IHttpActionResult GetAsync(string takipNo)
        {
            var result = _kTesellumAppService.GetAsync(takipNo);
            return Json(result);

        }
    }
}