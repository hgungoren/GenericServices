using AutoMapper;
using SK.SerendipGenericServise.KBirimApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KBirimApi.Application
{
    public class KBirimAppService : IKBirimAppService
    {
        private Mapper _mapper;
        public KBirimAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
            }));
        }

        public IEnumerable<KBirimListDto> GetAll()
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT ObjId, Adi FROM KBirim WHERE Aktif = 1 ");

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KBirimListDto>(result);
        }

        public KBirimDto GetByObjId(long id)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT ObjId, Adi FROM KBirim WHERE Aktif = 1 and ObjId=@prm0 ", new object[] { id });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KBirimDto>(result);
        }

        public KBirimDto GetByTrackingNo(string takipNo)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"
                SELECT Adi FROM KKargo 
                INNER JOIN KBirim  ON KKargo.Birimi_ObjId=KBirim.ObjId
                WHERE KKargo.TakipNo=@prm0 ", new object[] { takipNo });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KBirimDto>(result);
        }
    }
}