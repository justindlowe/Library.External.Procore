using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Library.External.Procore.Models
{
    public class Company
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        [JsonPropertyName("pcn_business_experience")]
        public bool? PcnBusinessExperience { get; set; }

        [JsonPropertyName("my_company")]
        public bool MyCompany { get; set; }
    }
}
