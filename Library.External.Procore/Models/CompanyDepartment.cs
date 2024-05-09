using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class CompanyDepartment
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("origin_data")]
        public string OriginData { get; set; }
        [JsonPropertyName("origin_id")]
        public string OriginId { get; set; }
    }
}
