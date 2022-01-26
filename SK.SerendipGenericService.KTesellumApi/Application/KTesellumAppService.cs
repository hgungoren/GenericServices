using AutoMapper;
using SK.SerendipGenericService.KTesellumApi.Application.Dto;
using SK.SerendipGenericService.KTesellumApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericService.KTesellumApi.Application
{
    public class KTesellumAppService : IKTesellumAppService
    {
        
        private Mapper _mapper;
        public KTesellumAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KTesellumDto, KTesellumResponseDto>();
            }));
        }



        public IEnumerable<KTesellumResponseDto> Get(string takipNo)

        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"select * from KTesellum where TEFKargoTakipNo = @prm0", new object[] { takipNo });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KTesellumResponseDto>(result);
        }
    }
}