using SK.SerendipGenericService.KKuryeLocationApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericService.KKuryeLocationApi.Application
{
    public interface IKKuryeLocationAppService
    {
        KKuryeLocationDto GetKKuryeLocationByKuryeObjId(long id);

        KKuryeLocationDto GetKKuryeLocationByTrackingNo(string takipNo);
    }
}
