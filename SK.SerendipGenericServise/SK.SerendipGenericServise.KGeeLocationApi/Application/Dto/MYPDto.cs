using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SK.SerendipGenericServise.KGeeLocationApi.Application.Dto
{
    public class MYPDto
    {
        public string MAPDATAID { get; set; }

        [JsonProperty("sonuc")]
        public string SONUC { get; set; }
        [JsonProperty("sonuc_ilceli")]
        public string SONUC_ILCELI { get; set; }
        public string XCOOR { get; set; }
        public string YCOOR { get; set; }
        [JsonProperty("mahalle_id")]
        public string MAHALLE_ID { get; set; }
        public string YOL_ID { get; set; }
        public string ILCE_ID { get; set; }
        public string IL_ID { get; set; }
        public string POI_ID { get; set; }
        public string NAME { get; set; }
        public string NAME_FULL { get; set; }
        public string LOVDATAPRIORITY { get; set; }
        public string AUDIT_CREATE_DATE { get; set; }
        public string AUDITCREATEDBY { get; set; }
        public string AUDITCREATEUNITID { get; set; }
        public string AUDIT_MODIFY_DATE { get; set; }
        public string AUDITMODIFIEDBY { get; set; }
        public string AUDITMODIFYUNITID { get; set; }
        public string AUDIT_DELETED { get; set; }
        public string APPLICATION_VERSION { get; set; }
        public string APPLICATIONID { get; set; }
        public string IL_ADI { get; set; }
        public string IL_STATE { get; set; }
        public string ILCE_ADI { get; set; }
        public string ILCE_STATE { get; set; }
        public string MAHALLE_ADI { get; set; }
        public string MAHALLE_STATE { get; set; }
        public string SOKAK_ADI { get; set; }
        public string SOKAK_STATE { get; set; }
        public string CADDE_ADI { get; set; }
        public string CADDE_STATE { get; set; }
        public string POI_ADI { get; set; }
        public string POI_STATE { get; set; }
        public string ISERROR { get; set; }
        public string MESSAGE { get; set; }
        public string MAPURL { get; set; }

    }
}