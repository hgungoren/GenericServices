using SK.SerendipGenericService.KFaturaApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericService.KFaturaApi.Application
{
    public interface IKFaturaAppService
    {
        KFaturaDto GetByTrackingNo(string takipNo);
    }
}
