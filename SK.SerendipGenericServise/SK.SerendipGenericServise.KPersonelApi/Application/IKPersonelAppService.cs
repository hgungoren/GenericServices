using SK.SerendipGenericServise.KPersonelApi.Application.ResponseDto;
using System.Collections.Generic;

namespace SK.SerendipGenericServise.KPersonelApi.Application
{
    public interface IKPersonelAppService  
    {
        IEnumerable<KPersonelIsyeriResponseDto> GetAll();
    }
}
