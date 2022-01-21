using SK.SerendipGenericServise.KGeeLocationApi.Application;
using System.Web.Http;

namespace SK.SerendipGenericServise.KGeeLocationApi.Controllers.v1
{
    public class KCityController : BaseController
    {


        private IKCityAppService _kCityAppService;
        public KCityController()
        {
            _kCityAppService = new KCityAppService();
        }

        public IHttpActionResult GetAllCity()
        {
            var result = _kCityAppService.GetAllCity();
            return Json(result,new Newtonsoft.Json.JsonSerializerSettings {});
        }

        public IHttpActionResult GetAllDistrict()
        {
            var result = _kCityAppService.GetAllDistrict();
            return Json(result);
        }

        public IHttpActionResult GetByIdDistrict(long cityId)
        {
            var result = _kCityAppService.GetByIdDistrict(cityId);
            return Json(result);
        }


        public IHttpActionResult GetByFindAddress(long districtId, string districtName, string myp_adi)
        {
            var result = _kCityAppService.GetByFindAddress(districtId, districtName, myp_adi);
            return Json(result);
        }

        public IHttpActionResult GetCountry()
        {
            var result = _kCityAppService.GetCountry();
            return Json(result);

        }


















    }
}