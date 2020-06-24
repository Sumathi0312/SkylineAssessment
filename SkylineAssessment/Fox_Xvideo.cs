using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineAssessment
{
    public class Fox_Xvideo
    {
        [JsonProperty("Device")]
        public string device { get; set; }
        [JsonProperty("Model")]
        public string model { get; set; }
        [JsonProperty("NIC")]
        public List<NIC> NICs { get; set; }
    }

    public class NIC {
        [JsonProperty("Description")] 
        public string description { get; set; }
        [JsonProperty("MAC")] 
        public string MAC { get; set; }
        [JsonProperty("Timestamp")] 
        public string ts { get; set; }
        [JsonProperty("Rx")] 
        public string rx { get; set; }
        [JsonProperty("Tx")] 
        public string tx { get; set; }
    }

    public class output {
        [JsonProperty("Description")]
        public string description { get; set; }
        [JsonProperty("MAC")]
        public string MAC { get; set; }
        [JsonProperty("Timestamp")]
        public string ts { get; set; }

        [JsonProperty("bitrateRx")]
        public long bitrateRx { get; set; }
        [JsonProperty("bitrateTx")]
        public long bitrateTx { get; set; }
    }
}


