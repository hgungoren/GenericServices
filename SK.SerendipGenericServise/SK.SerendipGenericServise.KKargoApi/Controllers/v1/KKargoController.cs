using SK.SerendipGenericServise.KKargoApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericServise.KKargoApi.Controllers.v1
{
    public class KKargoController : BaseController
    {

        private IKKargoAppService _ıKKargoAppService;

        public KKargoController()
        {
            _ıKKargoAppService = new KKargoAppService();
        }

        public IHttpActionResult GetById(string id) 
        {
            var result = _ıKKargoAppService.GetById(id);
            return Json(result);
        }

    }
}