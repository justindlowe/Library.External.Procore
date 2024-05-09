using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.External.Procore.Models
{
    public class ProjectDailyLogCount
    {
        [JsonPropertyName("module_name")]
        public string ModuleName { get; set; }
        [JsonPropertyName("count")]
        public int? Count { get; set; }
        [JsonPropertyName("position")]
        public int? Position { get; set; }
    }
}
