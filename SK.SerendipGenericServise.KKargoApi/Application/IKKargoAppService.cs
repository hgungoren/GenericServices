using SK.SerendipGenericServise.KKargoApi.Application.Dto;
using System.Collections.Generic;

namespace SK.SerendipGenericServise.KKargoApi.Application
{
    public interface IKKargoAppService
    {

        IEnumerable<CargoSumDto> GetById(string id);

    }
}
