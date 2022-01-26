using SK.SerendipGenericServise.KBirimApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KBirimApi.Application
{
    public interface IKBirimAppService
    {
        KBirimDto GetByTrackingNo(string takipNo);
        KBirimDto GetByObjId(long id);
        IEnumerable<KBirimListDto> GetAll();
    }
}