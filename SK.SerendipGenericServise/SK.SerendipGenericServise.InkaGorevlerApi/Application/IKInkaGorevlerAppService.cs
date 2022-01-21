using SK.SerendipGenericServise.InkaGorevlerApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericServise.InkaGorevlerApi.Application
{
    public interface IKInkaGorevlerAppService
    {

        IEnumerable<IKLookUpTableResponseDto> GetGorevler();

        IEnumerable<IKLookUpTableResponseDto> GetGorevler(string key);
    }
}
