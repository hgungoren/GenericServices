using SK.SerendipGenericService.KAdresApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericService.KAdresApi.Controllers.v1
{
    public class KAdresController : BaseController
    {
        private readonly IKAdresAppService _kAdresAppService;

        public KAdresController(IKAdresAppService kAdresAppService )
        {
            _kAdresAppService = kAdresAppService; 
        }
        [HttpGet]
        [Route("GetSenderAddressInfo/{takipNo}")]
        public IHttpActionResult GetSenderAddressInfo(string takipNo)
        {
            var data = _kAdresAppService.GetSenderAddressAsync(takipNo);
            return Json(data);
        }
        [HttpGet]
        [Route("GetReceiverAddressInfo/{takipNo}")]
        public IHttpActionResult GetReceiverAddressInfo(string takipNo)
        {
            var data = _kAdresAppService.GetReceiverAddressAsync(takipNo);
            return Json(data);
        }
    }
}