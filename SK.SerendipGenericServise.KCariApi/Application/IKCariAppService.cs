using SK.SerendipGenericServise.KCariApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericServise.KCariApi.Application
{
    public interface IKCariAppService
    {
        KCariDto GetByObjId(long id);
        KCariDto GetReceiverCurrent(string takipNo);

        KCariDto GetSenderCurrent(string takipNo);
        KDamageCompensationsCariDto GetCariListAsynDamage(string id);
    }
}
