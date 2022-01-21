using SK.SerendipGenericServise.KAracKaraApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericServise.KAracKaraApi.Application
{
     public interface IKAracKaraAppService
    {

        IEnumerable<KAracKaraResponseDto> GetAsync(long id);


    }
}
