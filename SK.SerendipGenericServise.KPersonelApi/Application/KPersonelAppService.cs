using AutoMapper;
using SK.SerendipGenericServise.KPersonelApi.Application.Dto;
using SK.SerendipGenericServise.KPersonelApi.Application.ResponseDto;
using System.Collections.Generic;

namespace SK.SerendipGenericServise.KPersonelApi.Application
{
    public class KPersonelAppService : IKPersonelAppService 
    {
        private Mapper _mapper;
        public KPersonelAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KPersonelIsyeriDto, KPersonelIsyeriResponseDto>(); 
            }));
        }

      

        public IEnumerable<KPersonelIsyeriResponseDto> GetAll()
        {
            var result = Serendip.Entity.Entity.FindAllBySql<KPersonelIsyeriDto>(@"SELECT TOP 10 
                S.Adi                   AS SubeAdi, 
                P.Ad                    AS PersonelAdi, 
                P.Soyad                 AS PersonelSoyadi,
                S.ObjId                 AS SubeObjId,
                S.BagliOlduguSube_ObjId AS SubeBagliOlduguSubeObjId FROM KPersonel (NOLOCK) P JOIN KSube (NOLOCK) S ON P.IsYeri_ObjId = S.ObjId
                WHERE P.Aktif = 1 AND S.Faaliyettemi = 1 AND S.Aktif = 1", new object[] { null });

            return _mapper.Map<List<KPersonelIsyeriResponseDto>>(result);
        }  
    }
}
