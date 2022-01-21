using SK.SerendipGenericService.KKargoHareketApi.Application.Dto;
using SK.SerendipGenericService.KKargoHareketApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericService.KKargoHareketApi.Application
{
    public interface IKKargoHareketAppService
    {
        KKargoHareketResponseDto Get(long id);
        KKargoHareketKuryeResponseDto GetKuryeObjId(long id);
        KKargoHareketAracResponseDto GetAracObjId(long id);
    }
}
