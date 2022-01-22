using AutoMapper;
using SK.SerendipGenericServise.KCariApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KCariApi.Application
{
    public class KCariAppService : IKCariAppService
    {
        private Mapper _mapper;
        public KCariAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
            }));
        }
        public KCariDto GetByObjId(long id)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"SELECT * FROM KCari WHERE ObjId = @prm0 ", new object[] { id });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToFirstOrDefault<KCariDto>(result);
        }

        public KDamageCompensationsCariDto GetCariListAsynDamage(string id)
        {
            throw new NotImplementedException();
        }

        public KCariDto GetReceiverCurrent(string takipNo)
        {
            // İstek yapılacak - sonra bakılacak
            throw new NotImplementedException();
        }

        public KCariDto GetSenderCurrent(string takipNo)
        {
            // İstek yapılacak - sonra bakılacak
            throw new NotImplementedException();
        }
    }
}