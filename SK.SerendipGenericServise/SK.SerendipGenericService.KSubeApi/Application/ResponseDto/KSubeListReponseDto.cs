using System.Collections.Generic;

namespace SK.SerendipGenericService.KSubeApi.Application.ResponseDto
{
    public class KSubeListReponseDto : Serendip.Entity.Entity
    {
        IList<KSubeReponseDto> KSubeListReponse { get; set; }
    }
}