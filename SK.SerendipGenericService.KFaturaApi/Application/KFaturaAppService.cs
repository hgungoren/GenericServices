using AutoMapper;
using SK.SerendipGenericService.KFaturaApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KFaturaApi.Application
{
    public class KFaturaAppService : IKFaturaAppService
    {
        private Mapper _mapper;
        public KFaturaAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
            }));
        }
        public KFaturaDto GetByTrackingNo(string takipNo)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"
                SELECT KFatura.TEFTarih , KKargo.OperasyonTarihi  FROM kkargo 
                INNER JOIN kfatura ON kkargo.Fatura_ObjId = KFatura.ObjId
                WHERE KKargo.TakipNo=@prm0 ", new object[] { takipNo });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KFaturaDto>(result);
        }
    }
}