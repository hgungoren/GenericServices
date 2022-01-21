using AutoMapper;
using SK.SerendipGenericServise.KAracKaraApi.Application.Dto;
using SK.SerendipGenericServise.KAracKaraApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KAracKaraApi.Application
{
    public class KAracKaraAppService : IKAracKaraAppService
    {
        private Mapper _mapper;
        public KAracKaraAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KAracKaraDto, KAracKaraResponseDto>();
            }));
        }



        public IEnumerable<KAracKaraResponseDto> GetAsync(long id)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT * FROM KAracKara where ObjId=@prm0", new object[] { id });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KAracKaraResponseDto>(result);
        }
    }
}