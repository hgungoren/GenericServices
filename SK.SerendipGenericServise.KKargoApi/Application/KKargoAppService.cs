using AutoMapper;
using SK.SerendipGenericServise.Core.Enums;
using SK.SerendipGenericServise.KKargoApi.Application.Dto;
using SK.SerendipGenericServise.KKargoApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SK.SerendipGenericServise.KKargoApi.Application
{
    public class KKargoAppService :IKKargoAppService
    {

        private Mapper _mapper;

        public KKargoAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KKargoDto, KKargoResponseDto>();
            }));
        }

        public IEnumerable<CargoSumDto> GetById(string id)
        {
            //api / kkargo / GetById ? id = 3120000100000000297

            #region SQL KARGO GELEN-GİDEN SORGU
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"declare @bastar datetime, @bittar datetime
set @bastar =DATEADD(month,-3,GETDATE())
set @bittar =GETDATE()
select
DATEPART(YEAR,p.EvrakTarihi) Yil
,DATEPART(MONTH,p.EvrakTarihi) Ay
,p.SubeObjId,sum(p.EvrakAdedi) EvrakAdedi ,1 as Tip
from
(
select
cast(k.TEFTarih as date) EvrakTarihi
,vs.ObjId SubeObjId
,count(k.ObjId) EvrakAdedi
from
KFatura k (nolock)
inner join KSube vs (nolock) on k.TEFVarisSubesi_ObjId=vs.ObjId
where
k.TEFIptalDurumu in (1,10)
and k.FaturaTuru not in (2,6)
and k.TEFTarih between @bastar and @bittar
and k.TEFHizmeti_ObjId=3120000100000000000
group by cast(k.TEFTarih as date),vs.ObjId
union all
select
cast(k.TEFTarih as date) EvrakTarihi
,vs.ObjId SubeObjId
,count(k.ObjId) EvrakAdedi
from
KTesellum k (nolock)
inner join KSube vs (nolock) on k.TEFVarisSubesi_ObjId=vs.ObjId
where
k.TEFIptalDurumu in (1,10)
and k.TesellumTuru=200
and k.TEFTarih between @bastar and @bittar
and k.TEFHizmeti_ObjId=3120000100000000000
group by cast(k.TEFTarih as date),vs.ObjId
) p
where p.SubeObjId=@prm0
group by DATEPART(YEAR,p.EvrakTarihi),DATEPART(MONTH,p.EvrakTarihi),p.SubeObjId
UNION ALL
select
DATEPART(YEAR,p.EvrakTarihi) Yil
,DATEPART(MONTH,p.EvrakTarihi) Ay
,p.SubeObjId,sum(p.EvrakAdedi) EvrakAdedi,2 as Tip
from
(
select
cast(k.TEFTarih as date) EvrakTarihi
,gs.ObjId SubeObjId
,count(k.ObjId) EvrakAdedi
from
KFatura k (nolock)
inner join KSube gs (nolock) on k.TEFGonderenSube_ObjId=gs.ObjId
where
k.TEFIptalDurumu in (1,10)
and k.FaturaTuru not in (2,6)
and k.TEFTarih between @bastar and @bittar
and k.TEFHizmeti_ObjId=3120000100000000000
group by cast(k.TEFTarih as date),gs.ObjId
union all
select
cast(k.TEFTarih as date) EvrakTarihi
,gs.ObjId SubeObjId
,count(k.ObjId) EvrakAdedi
from
KTesellum k (nolock)
inner join KSube gs (nolock) on k.TEFGonderenSube_ObjId=gs.ObjId
where
k.TEFIptalDurumu in (1,10)
and k.TesellumTuru=200
and k.TEFTarih between @bastar and @bittar
and k.TEFHizmeti_ObjId=3120000100000000000
group by cast(k.TEFTarih as date),gs.ObjId
) p
where p.SubeObjId=@prm0
group by DATEPART(YEAR,p.EvrakTarihi),DATEPART(MONTH,p.EvrakTarihi),p.SubeObjId
order by  Yil,Ay,Tip desc 
option(recompile)", new object[] { id });
            #endregion


            List<KKargoResponseDto> tbl=SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KKargoResponseDto>(result);

            List<CargoSumDto> csdtoList = new List<CargoSumDto>();

            if (tbl.Count > 0)
            {
                tbl = tbl.Take(6).ToList();

                CargoSumDto csdto = new CargoSumDto();

                csdto.OutcomingMonthOne = Enum.GetName(typeof(Month), tbl[0].Ay);
                csdto.OutcomingMonthOneAverage = tbl[0].EvrakAdedi / 30;

                csdto.IncomingMonthOne = Enum.GetName(typeof(Month), tbl[1].Ay);
                csdto.IncomingMonthOneAverage = tbl[1].EvrakAdedi / 30;


                csdto.OutcomingMonthTwo = Enum.GetName(typeof(Month), tbl[2].Ay);
                csdto.OutcomingMonthTwoAverage = tbl[2].EvrakAdedi / 30;

                csdto.IncomingMonthTwo = Enum.GetName(typeof(Month), tbl[3].Ay);
                csdto.IncomingMonthTwoAverage = tbl[3].EvrakAdedi / 30;


                csdto.OutcomingMonthThree = Enum.GetName(typeof(Month), tbl[4].Ay);
                csdto.OutcomingMonthThreeAverage = tbl[4].EvrakAdedi / 30;

                csdto.IncomingMonthThree = Enum.GetName(typeof(Month), tbl[5].Ay);
                csdto.IncomingMonthThreeAverage = tbl[5].EvrakAdedi / 30;
                csdtoList.Add(csdto);

                return csdtoList;

            }
            else {
                return csdtoList;
            }










        }


    }
}