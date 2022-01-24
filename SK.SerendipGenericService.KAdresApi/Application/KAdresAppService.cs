using AutoMapper;
using SK.SerendipGenericService.KAdresApi.Application.Dto;
using SK.SerendipGenericService.KAdresApi.Application.ResponseDto;
using System;
using Serendip.Entity;

namespace SK.SerendipGenericService.KAdresApi.Application
{
    public class KAdresAppService : IKAdresAppService
    {
        private Mapper _mapper;
        public KAdresAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KAdresDto, KAdresResponseDto>();
            }));
        }
        public KAdresResponseDto GetReceiverAddressAsync(string takipNo)
        {
            var result = Entity.FindAllBySql<KAdresResponseDto>(@"select ka.AdresSatiri
from KAdres(nolock) ka
    inner join KKargo(nolock) kk
        on ka.ObjId = kk.AliciAdresi_ObjId
where kk.TakipNo = @prm0", new object[] { takipNo });

            return _mapper.Map<KAdresResponseDto>(result);
        }

        public KAdresResponseDto GetSenderAddressAsync(string takipNo)
        {
            var result = Entity.FindAllBySql<KAdresResponseDto>(@"select ka.AdresSatiri
from KAdres ka
    inner join KKargo kk
        on ka.ObjId = kk.GonderenAdresi_ObjId
where kk.TakipNo = @prm0", new object[] { takipNo });

            return _mapper.Map<KAdresResponseDto>(result);
        }
    }
}