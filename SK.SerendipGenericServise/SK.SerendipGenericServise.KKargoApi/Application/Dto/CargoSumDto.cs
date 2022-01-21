
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SK.SerendipGenericServise.KKargoApi.Application.Dto
{
    [Serializable]
    public class CargoSumDto
    {
        [JsonProperty("incomingMonthOne")]
        public string IncomingMonthOne { get; set; }

        [JsonProperty("incomingMonthTwo")]
        public string IncomingMonthTwo { get; set; }

        [JsonProperty("incomingMonthThree")]
        public string IncomingMonthThree { get; set; }

        [JsonProperty("incomingMonthOneAverage")]
        public double IncomingMonthOneAverage { get; set;}

        [JsonProperty("incomingMonthTwoAverage")]
        public double IncomingMonthTwoAverage { get;set;}

        [JsonProperty("incomingMonthThreeAverage")]
        public double IncomingMonthThreeAverage { get; set; }


        [JsonProperty("outcomingMonthOne")]
        public string OutcomingMonthOne { get; set; }

        [JsonProperty("outcomingMonthTwo")]
        public string OutcomingMonthTwo { get; set; }

        [JsonProperty("outcomingMonthThree")]
        public string OutcomingMonthThree { get; set; }

        [JsonProperty("outcomingMonthOneAverage")]
        public double OutcomingMonthOneAverage { get; set; }

        [JsonProperty("outcomingMonthTwoAverage")]
        public double OutcomingMonthTwoAverage { get; set; }

        [JsonProperty("outcomingMonthThreeAverage")]
        public double OutcomingMonthThreeAverage { get; set; }

    }
}