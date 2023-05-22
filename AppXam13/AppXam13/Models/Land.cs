using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppXam13.Models
{
    public class Land
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "callingCodes")]
        public List<string> CallingCodes { get; set; }

        [JsonProperty(PropertyName = "capital")]
        public string Capital { get; set; }

        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }

        [JsonProperty(PropertyName = "numericCode")]
        public string NumericCode { get; set; }

        [JsonProperty(PropertyName = "currencies")]
        public List<Currency> Currencies { get; set; }

        [JsonProperty(PropertyName = "flag")]
        public string Flag { get; set; }

    }
}
