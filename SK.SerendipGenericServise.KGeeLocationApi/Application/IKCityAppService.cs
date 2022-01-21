using SK.SerendipGenericServise.KGeeLocationApi.Application.Dto;
using SK.SerendipGenericServise.KGeeLocationApi.Application.ResponseDto;
using System.Collections.Generic;

namespace SK.SerendipGenericServise.KGeeLocationApi.Application
{
    public interface IKCityAppService
    {
        IEnumerable<KCityResponseDto> GetAllCity();
        IEnumerable<KDistrictrResponseDto> GetAllDistrict();

        IEnumerable<KDistrictrResponseDto> GetByIdDistrict(long cityId);

        IEnumerable<MYPDto> GetByFindAddress(long districtId, string districtName, string myp_adi);

        IEnumerable<KCountryResponseDto> GetCountry();





    }
}
