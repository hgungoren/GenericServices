using AutoMapper;
using Serendip.Entity;
using SK.SerendipGenericService.KKullaniciApi.Application.Dto;
using SK.SerendipGenericService.KKullaniciApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KKullaniciApi.Application
{
    public class KKullaniciAppService : IKKullaniciAppService
    {
        private Mapper _mapper;

        public KKullaniciAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KKullaniciDto, KKullaniciResponseDto>();
            }));
        }
        public KKullaniciResponseDto GetMail(long id)
        {
            var sube = Entity.FindAllBySql<KKullaniciResponseDto>(@"select * from Kullanici(nolock) where ObjId=@prm0", new object[] { id });

            return _mapper.Map<KKullaniciResponseDto>(sube);
        }
    }
}