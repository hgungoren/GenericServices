using SK.SerendipGenericService.KSubeApi.Application.ResponseDto;
using System.Collections.Generic;

namespace SK.SerendipGenericService.KSubeApi.Application
{
    public interface IKSubeAppService
    {
        List<KSubeReponseDto> GetKBolgeAll();
        List<KSubeReponseDto> GetKSube(string id);
        List<KSubeReponseDto> GetByCode(string code);
        KSubeReponseDto GetSenderBranchInfo(string takipNo);
        KSubeReponseDto GetReceiverBranchInfo(string takipNo);
        List<long> GetBranchIds(long id); 
        KSubeReponseDto GetKSubeById(string id); 
        List<KSubeResponseListDamageDto> GetKSubeListDamage(); 
        List<KSubeResponseListDamageDto> GetKBolgeListDamage();
    }
}
