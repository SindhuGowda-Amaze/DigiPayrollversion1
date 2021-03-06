using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class Ganalytics
    {
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }

        [JsonProperty(PropertyName = "utm_source")]
        public string UtmSource { get; set; }

        [JsonProperty(PropertyName = "utm_medium")]
        public string UtmMedium { get; set; }

        [JsonProperty(PropertyName = "utm_term")]
        public string UtmTerm { get; set; }

        [JsonProperty(PropertyName = "utm_content")]
        public string UtmContent { get; set; }

        [JsonProperty(PropertyName = "utm_campaign")]
        public string UtmCampaign { get; set; }
    }
}