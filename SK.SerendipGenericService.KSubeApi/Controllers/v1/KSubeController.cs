using SK.SerendipGenericService.KSubeApi.Application;
using System.Web.Http;
using System.Web.Mvc;

namespace SK.SerendipGenericService.KSubeApi.Controllers.v1
{
    public class KSubeController : BaseController
    {
        private IKSubeAppService _kSubeAppService; 

        public KSubeController()
        {
            _kSubeAppService = new KSubeAppService();
        } 

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("KBolge")]
        public IHttpActionResult GetKBolge()
        {
            var data = _kSubeAppService.GetKBolgeAll();
            return Json(data);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("KSube")]
        public IHttpActionResult GetKSube(string id)
        {
            var data = _kSubeAppService.GetKSube(id);
            return Json(data);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetById/{id}")]
        public IHttpActionResult GetById(string id)
        {
            var data = _kSubeAppService.GetKSubeById(id);
            return Json(data);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetBranchIds/{id}")]
        public IHttpActionResult GetBranchIds(long id)
        {
            var data = _kSubeAppService.GetBranchIds(id);
            return Json(data);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetByCode/{code}")]
        public IHttpActionResult GetByCode(string code)
        {
            var data = _kSubeAppService.GetByCode(code);
            return Json(data);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetSenderBranchInfo/{takipNo}")]
        public IHttpActionResult GetSenderBranchInfo(string takipNo)
        { 
            var data = _kSubeAppService.GetSenderBranchInfo(takipNo);
            if (data != null)
            {
                return Ok(data);
            } 
            return NotFound();
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetReceiverBranchInfo/{takipNo}")]
        public IHttpActionResult GetReceiverBranchInfo(string takipNo)
        {
            var data = _kSubeAppService.GetReceiverBranchInfo(takipNo);
            if (data != null)
            {
                return Ok(data);
            } 
            return NotFound();

        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetKSubeListDamageAll")]
        public IHttpActionResult GetKSubeListDamage()
        {
            var data = _kSubeAppService.GetKSubeListDamage();
            return Ok(data);
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetKBolgeListDamageAll")]
        public IHttpActionResult GetKBolgeListDamage()
        {
            var data = _kSubeAppService.GetKBolgeListDamage();
            return Ok(data);
        }
    }
}