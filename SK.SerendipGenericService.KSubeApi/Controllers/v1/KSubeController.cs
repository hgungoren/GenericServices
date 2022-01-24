using SK.SerendipGenericService.KSubeApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericService.KSubeApi.Controllers.v1
{
    public class KSubeController : BaseController
    {
        private IKSubeAppService _kSubeAppService; 

        public KSubeController()
        {
            _kSubeAppService = new KSubeAppService();
        } 

        [HttpGet]
        [Route("KBolge")]
        public IHttpActionResult GetKBolge()
        {
            var data = _kSubeAppService.GetKBolgeAll();
            return Json(data);
        }
        [HttpGet]
        [Route("KSube")]
        public IHttpActionResult GetKSube(string id)
        {
            var data = _kSubeAppService.GetKSube(id);
            return Json(data);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IHttpActionResult GetById(string id)
        {
            var data = _kSubeAppService.GetKSubeById(id);
            return Json(data);
        }
        [HttpGet]
        [Route("GetBranchIds/{id}")]
        public IHttpActionResult GetBranchIds(long id)
        {
            var data = _kSubeAppService.GetBranchIds(id);
            return Json(data);
        }
        [HttpGet]
        [Route("GetByCode/{code}")]
        public IHttpActionResult GetByCode(string code)
        {
            var data = _kSubeAppService.GetByCode(code);
            return Json(data);
        }
        [HttpGet]
        [Route("GetSenderBranchInfo/{takipNo}")]
        public IHttpActionResult GetSenderBranchInfo(string takipNo)
        { 
            var data = _kSubeAppService.GetSenderBranchInfo(takipNo);
            if (data != null)
            {
                return Ok(data);
            } 
            return NotFound();
        }
        [HttpGet]
        [Route("GetReceiverBranchInfo/{takipNo}")]
        public IHttpActionResult GetReceiverBranchInfo(string takipNo)
        {
            var data = _kSubeAppService.GetReceiverBranchInfo(takipNo);
            if (data != null)
            {
                return Ok(data);
            } 
            return NotFound();

        }
        [HttpGet]
        [Route("GetKSubeListDamageAll")]
        public IHttpActionResult GetKSubeListDamage()
        {
            var data = _kSubeAppService.GetKSubeListDamage();
            return Ok(data);
        }
        [HttpGet]
        [Route("GetKBolgeListDamageAll")]
        public IHttpActionResult GetKBolgeListDamage()
        {
            var data = _kSubeAppService.GetKBolgeListDamage();
            return Ok(data);
        }
    }
}