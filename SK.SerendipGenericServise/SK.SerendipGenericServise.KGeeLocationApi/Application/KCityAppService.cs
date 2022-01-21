using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using SK.SerendipGenericServise.KGeeLocationApi.Application.Dto;
using SK.SerendipGenericServise.KGeeLocationApi.Application.ResponseDto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SK.SerendipGenericServise.KGeeLocationApi.Application
{
    public class KCityAppService : IKCityAppService
    {

        private Mapper _mapper;

         public KCityAppService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KCityDto, KCityResponseDto>();
            }));
        }


        public IEnumerable<KCityResponseDto> GetAllCity()
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"select ObjId as ObjID, 
               Aciklama as Aciklama,
               Adi AS Adi,
               Aktif as Aktif
               from Il ", new object[] { null});

            //yield return ConvertToFirstOrDefault<KCityResponseDto>(result);
            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KCityResponseDto>(result);
            // return _mapper.Map<List<KCityResponseDto>>(result);
        }


        public IEnumerable<KDistrictrResponseDto> GetAllDistrict()
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"select ObjId as ObjID, 
               Aciklama    as Aciklama,
               Adi         as Adi,
               Aktif       as Aktif
               from Ilce ", new object[] { null });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KDistrictrResponseDto>(result);
        }


        public IEnumerable<KDistrictrResponseDto> GetByIdDistrict(long cityId)
        {
            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"select ObjId as ObjID, 
               Aciklama as Aciklama,
               Adi AS Adi,
               Aktif as Aktif,
               Ili_ObjId as Ili_ObjId
               from Ilce  where   Ili_ObjId =@prm0", new object[] { cityId });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KDistrictrResponseDto>(result);
        }

        public IEnumerable<MYPDto> GetByFindAddress(long districtId, string districtName , string myp_adi)
        {
            List<MYPDto> MYPModel = new List<MYPDto>();
            List<MYPDto> districtMYPModel = new List<MYPDto>();


            string districtRoad = "http://172.27.30.23/GeoService/Api/ILCE";
            HttpWebRequest districtrequest = (HttpWebRequest)WebRequest.Create(districtRoad);
            districtrequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse districtresponse = (HttpWebResponse)districtrequest.GetResponse())
            using (Stream districtstream = districtresponse.GetResponseStream())
            using (StreamReader districtreader = new StreamReader(districtstream))
            {
                string districtmodel = districtreader.ReadToEnd();
                districtMYPModel = JsonConvert.DeserializeObject<List<MYPDto>>(districtmodel);
            }

            string cityid = Convert.ToString(districtId);
            var data = districtMYPModel.Where(x => x.IL_ID == cityid && x.ILCE_ADI == districtName).FirstOrDefault();
            if(data == null)
            {
                return MYPModel;
            }
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://172.27.30.23/GeoService/Api/MYP?ILCE_ID=" + data.ILCE_ID + "&SEARCH=" + myp_adi);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response=(HttpWebResponse)request.GetResponse())
            using (Stream stream=response.GetResponseStream())
            using (StreamReader reader=new StreamReader(stream))
            {
                string model = reader.ReadToEnd();
                MYPModel = JsonConvert.DeserializeObject<List<MYPDto>>(model);
            }

            return MYPModel;
        }


        public IEnumerable<KCountryResponseDto> GetCountry()
        {

            var result = Serendip.Entity.Entity.ActiveRecord.ExecuteTable(@"select ObjId as ObjID, 
               Aciklama as Aciklama,
               Adi AS Adi,
               Aktif as Aktif
               from ulke", new object[] { null });

            return SK.SerendipGenericServise.Core.GenericDatatable.CoreGenericDatable.ConvertToList<KCountryResponseDto>(result);

        }











    }
}