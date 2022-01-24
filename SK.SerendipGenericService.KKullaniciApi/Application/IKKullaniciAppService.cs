using SK.SerendipGenericService.KKullaniciApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericService.KKullaniciApi.Application
{
    public interface IKKullaniciAppService
    {
         KKullaniciResponseDto GetMail(long id);
    }
}
