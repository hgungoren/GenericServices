using AutoMapper;
using SK.SerendipGenericServise.InkaGorevlerApi.Application.Dto;
using SK.SerendipGenericServise.InkaGorevlerApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SK.SerendipGenericServise.InkaGorevlerApi.Application
{
    public class KInkaGorevlerAppService :IKInkaGorevlerAppService
    {

        private Mapper _mapper;
        public KInkaGorevlerAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IKLookUpTableDto, IKLookUpTableResponseDto>();
            }));
        }


        //https://localhost:44322/api/KInkaGorevler/GetGorevler

    
        public IEnumerable<IKLookUpTableResponseDto> GetGorevler()
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"select  * from IKLookUpTable  (nolock) where Aktif=1  and ListName='GÖREV' order by Adi  ", new object[] { null });
    
            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<IKLookUpTableResponseDto>(result);
        }

       
        public IEnumerable<IKLookUpTableResponseDto> GetGorevler(string key)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"select  ObjId, Adi,Aciklama1,ParentKodu,Aktif from IKLookUpTable  (nolock) where Aktif=1  and ListName='GÖREV'  and ParentKodu LIKE '%'+@prm0+'%'  order by Adi
   ", new object[] { key });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<IKLookUpTableResponseDto>(result);
        }

    }
}