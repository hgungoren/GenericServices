using AutoMapper;
using SK.SerendipGenericService.KKargoHareketApi.Application.Dto;
using SK.SerendipGenericService.KKargoHareketApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KKargoHareketApi.Application
{
    public class KKargoHareketAppService : IKKargoHareketAppService
    {

        private Mapper _mapper;
        public KKargoHareketAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KKargoHareketDto, KKargoHareketResponseDto>();
                cfg.CreateMap<KKargoHareketDto, KKargoHareketAracResponseDto>();
                cfg.CreateMap<KKargoHareketDto, KKargoHareketKuryeResponseDto>();
            }));
        }
        public KKargoHareketResponseDto Get(long id)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT * FROM KKargoHareket WHERE ObjId = @prm0", new object[] { id });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KKargoHareketResponseDto>(result);
        }

        public KKargoHareketAracResponseDto GetAracObjId(long id)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT TOP 1 
                Arac_ObjId FROM KKargoHareket 
                WHERE HareketTip = 6 
                AND Kargo_ObjId = @prm0 
                ORDER BY HareketTar", new object[] { id });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KKargoHareketAracResponseDto>(result);
        }

        public KKargoHareketKuryeResponseDto GetKuryeObjId(long id)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT TOP 1 
                Kurye_ObjId FROM KKargoHareket 
                WHERE HareketTip = 30 
                AND Kargo_ObjId = @prm0 
                ORDER BY HareketTar", new object[] { id });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KKargoHareketKuryeResponseDto>(result);
        }
    }
}