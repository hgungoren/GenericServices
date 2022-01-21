using SK.SerendipGenericService.KTesellumApi.Application.ResponseDto;
using System.Collections.Generic;

namespace SK.SerendipGenericService.KTesellumApi.Application
{
    public interface IKTesellumAppService
    {
        IEnumerable<KTesellumResponseDto> GetAsync(string takipNo);
    }
}