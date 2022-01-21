using SK.SerendipGenericServise.KPersonelApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericServise.KPersonelApi.Controllers.v1
{
    public class KPersonelController : BaseController
    {
        private IKPersonelAppService _kPersonelAppService;
        public KPersonelController()
        {
            _kPersonelAppService = new KPersonelAppService();
        }
         
        public IHttpActionResult GetAll()
        { 
            var result = _kPersonelAppService.GetAll();
            return Json(result);
        }
    }
}
