using SK.SerendipGenericService.KAdresApi.Application;
using System.Web.Http;
using System.Web.Mvc;

namespace SK.SerendipGenericService.KAdresApi.Controllers.v1
{
    public class KAdresController : BaseController
    {
        private readonly IKAdresAppService _kAdresAppService;

        public KAdresController(IKAdresAppService kAdresAppService )
        {
            _kAdresAppService = kAdresAppService; 
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetSenderAddressInfo/{takipNo}")]
        public IHttpActionResult GetSenderAddressInfo(string takipNo)
        {
            var data = _kAdresAppService.GetSenderAddressAsync(takipNo);
            return Json(data);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetReceiverAddressInfo/{takipNo}")]
        public IHttpActionResult GetReceiverAddressInfo(string takipNo)
        {
            var data = _kAdresAppService.GetReceiverAddressAsync(takipNo);
            return Json(data);
        }
    }
}