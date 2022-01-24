using AutoMapper;
using SK.SerendipGenericService.KKuryeLocationApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KKuryeLocationApi.Application
{
    public class KKuryeLocationAppService : IKKuryeLocationAppService
    {
        private Mapper _mapper;
        public KKuryeLocationAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<KKargoHareketDto, KKargoHareketResponseDto>();
                //cfg.CreateMap<KKargoHareketDto, KKargoHareketAracResponseDto>();
                //cfg.CreateMap<KKargoHareketDto, KKargoHareketKuryeResponseDto>();
            }));
        }
        public KKuryeLocationDto GetKKuryeLocationByKuryeObjId(long id)
        {
            // Sistem_InsertTime sorgu gelmemektedir.
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT TOP 1 * FROM KKuryeLokasyon 
                WHERE Kurye_ObjId = @prm0 
                --ORDER BY Sistem_InsertTime DESC", new object[] { id });
            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KKuryeLocationDto>(result);
        }


        //Aynı takip numarasına birden fazla kkargo kaydı gelmekte, gelenlerin içinde de farklı kurye objId bulunmaktadır.
        public KKuryeLocationDto GetKKuryeLocationByTrackingNo(string takipNo)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT TOP 1 * FROM KKuryeLokasyon
                INNER JOIN KKargo on KKuryeLokasyon.Kurye_ObjId=KKargo.Kurye_ObjId
                WHERE KKargo.TakipNo = @prm0
                --ORDER BY Sistem_InsertTime DESC", new object[] { takipNo });
            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KKuryeLocationDto>(result);
        }
    }
}