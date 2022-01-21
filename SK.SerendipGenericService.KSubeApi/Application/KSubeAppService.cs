using AutoMapper;
using Serendip.Entity;
using SK.SerendipGenericService.KSubeApi.Application.Dto;
using SK.SerendipGenericService.KSubeApi.Application.ResponseDto;
using SK.SerendipGenericServise.KPersonelApi.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SK.SerendipGenericService.KSubeApi.Application
{
    public class KSubeAppService : IKSubeAppService
    {
        private Mapper _mapper;

        public KSubeAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KSubeDto, KSubeReponseDto>();
            }));
        }

        public List<long> GetBranchIds(long id)
        {
            var result = Entity.FindAllBySql<KSubeDto>(@"select ObjId from KSube(nolock) where Aktif=1 and Faaliyettemi=1 and (KSube.ObjId=@prm0 or KSube.BagliOlduguSube_ObjId=@prm1)", new object[] { id, id });

            return _mapper.Map<List<long>>(result);
        }

        public List<KSubeReponseDto> GetByCode(string code)
        {
            var result = Entity.FindAllBySql<KSubeDto>(@"select * from KSube(nolock) where Aktif=1 and Faaliyettemi=1 and KSube.Kodu=@prm0", new object[] { code });

            return _mapper.Map<List<KSubeReponseDto>>(result);
        }

        public List<KSubeReponseDto> GetKBolgeAll()
        { 
            List<KSubeDto> branches = new List<KSubeDto>();
              
                var all = Entity.FindAllBySql<KSubeDto>(@"select * from KSube(nolock) where Aktif=1 and Faaliyettemi=1 and Tipi=2 and Tiptur=1", new object[] { null });

                var personellist = Entity.FindAllBySql<KPersonelDto>(@"select * from KPersonel where Aktif=1", new object[] { null });
                int allcount = all.Count();
                foreach (var branch in all)
                {
                    var k2 = Entity.FindAllBySql<KSubeDto>(@"select * from KSube(nolock) ks inner join KSube(nolock) kb on ks.BagliOlduguSube_ObjId=kb.ObjId where ks.Aktif=1 and ks.Faaliyettemi=1 and ks.BagliOlduguSube_ObjId=@prm0", new object[] { branch.ObjId });
                    int count = 0;
                    foreach (var item in k2)
                    {
                        long tt = long.Parse(item.ObjId);
                        int cc = personellist.Where(x => x.IsYeri_ObjId == tt).Count();
                        count = count + cc;
                    }

                    KSubeDto branchDto = new KSubeDto();
                    branchDto.Adi = branch.Adi;
                    branchDto.Aktif = branch.Aktif;
                    branchDto.PersonelSayisi = count;
                    branchDto.ObjId = branch.ObjId.ToString();
                    branchDto.Tipi = branch.Tipi;
                    branchDto.TipTur = branch.TipTur;
                    branchDto.ToplamSayi = allcount;
                    branches.Add(branchDto);
                }
             
            return _mapper.Map<List<KSubeReponseDto>>(branches);
              
        }

        public List<KSubeReponseDto> GetKSube(string id)
        {
            long bolgeId = long.Parse(id); 

            var result = Entity.FindAllBySql<KSubeDto>(@"select s.Adi,s.Aktif,count(p.ObjId) PersonelSayisi,s.ObjId,s.Tipi,s.TipTur,s.BagliOlduguSube_ObjId from KSube(nolock) k inner join KSube(nolock) s on s.BagliOlduguSube_ObjId=k.ObjId inner join KPersonel(nolock) p on p.IsYeri_ObjId=s.ObjId where k.ObjId=@prm0 and p.Aktif=1 group by s.Adi,s.Aktif,s.ObjId,s.Tipi,s.TipTur,s.BagliOlduguSube_ObjId", new object[] { bolgeId });

            List<KSubeDto> branchs = new List<KSubeDto>();

            foreach (var sube in result)
            { 
                int count = Entity.FindAllBySql<KPersonelDto>(@"select * from KSube k inner join KPersonel p on p.IsYeri_ObjId=k.ObjId where k.ObjId=@prm0 and p.Aktif=1", new object[] { bolgeId }).Count();
                KSubeDto subeDto = new KSubeDto();
                subeDto.Adi = sube.Adi;
                subeDto.Aktif = sube.Aktif;
                subeDto.PersonelSayisi = count;
                subeDto.ObjId = sube.ObjId.ToString();
                subeDto.Tipi = sube.Tipi;
                subeDto.TipTur = sube.TipTur;
                subeDto.ToplamSayi = result.Count();
                subeDto.BagliOlduguSube_ObjId = sube.BagliOlduguSube_ObjId.ToString();
                branchs.Add(subeDto);
            }
            return _mapper.Map<List<KSubeReponseDto>>(branchs);
        }
         
        public KSubeReponseDto GetReceiverBranchInfo(string takipNo)
        {  

            var data = Entity.FindAllBySql<KSubeDto>(@"select top 1 ks.Adi from KSube ks inner join KKargo k on k.VarisSube_ObjId=ks.ObjId where k.TakipNo=@prm0", new object[] { takipNo });

            if (data != null)
            {
                return _mapper.Map<KSubeReponseDto>(data);
            }

            return _mapper.Map<KSubeReponseDto>(null);
        }

        public KSubeReponseDto GetSenderBranchInfo(string takipNo)
        {
            var data = Entity.FindAllBySql<KSubeDto>(@"select top 1 ks.Adi from KSube ks inner join KKargo k on k.AliciSube_ObjId=ks.ObjId where k.TakipNo=@prm0", new object[] { takipNo });

            if (data != null)
            {
                return _mapper.Map<KSubeReponseDto>(data);
            }

            return _mapper.Map<KSubeReponseDto>(null);
        }

        public KSubeReponseDto GetKSubeById(string id)
        {
            var sube = Entity.FindAllBySql<KSubeDto>(@"select * from KSube(nolock) where ObjId=@prm0", new object[] { id });

            return _mapper.Map<KSubeReponseDto>(sube);
        }

        public List<KSubeResponseListDamageDto> GetKSubeListDamage()
        {
            List<KSubeResponseListDamageDto> branches = new List<KSubeResponseListDamageDto>();

            var data = Entity.FindAllBySql<KSubeResponseListDamageDto>(@"select * from KSube(nolock) where Aktif=1 and Faaliyettemi=1 and TipTur=1 and (Tipi=4 or Tipi=5)", new object[] { null });
            foreach (var item in data)
            {
                KSubeResponseListDamageDto ks = new KSubeResponseListDamageDto();
                ks.Adi = item.Adi;
                ks.ObjId = Convert.ToString(item.ObjId); 
                branches.Add(ks); 
            }
            return branches;
        }

        public List<KSubeResponseListDamageDto> GetKBolgeListDamage()
        {
            List<KSubeResponseListDamageDto> branches = new List<KSubeResponseListDamageDto>();

            var data = Entity.FindAllBySql<KSubeResponseListDamageDto>(@"select * from KSube(nolock) where Aktif=1 and Faaliyettemi=1 and TipTur=1 and (Tipi=2 or Tipi=1)", new object[] { null });
            foreach (var item in data)
            {
                KSubeResponseListDamageDto ks = new KSubeResponseListDamageDto();
                ks.Adi = item.Adi;
                ks.ObjId = Convert.ToString(item.ObjId);
                branches.Add(ks);
            }
            return branches;
        }

         
    }
}